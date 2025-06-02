using System; // 匯入基本系統命名空間，提供基本類型與方法
using System.Collections.Generic; // 匯入泛型集合命名空間，用於 Dictionary、List 等
using System.Drawing; // 匯入繪圖命名空間，用於處理顏色、圖形等
using System.Linq; // 匯入 LINQ 命名空間，用於集合操作
using System.Windows.Forms; // 匯入 WinForms 命名空間，用於建立視窗應用程式
using System.IO; // 匯入檔案系統命名空間，用於檔案讀寫
using Newtonsoft.Json; // 匯入 JSON 處理套件，用於序列化與反序列化

namespace KStudyCenterAdmin // 定義命名空間
{
    public partial class MainForm : Form // 定義主視窗類別，繼承自 Form
    {
        private Dictionary<DateTime, List<Reservation>> reservationsByDate = new Dictionary<DateTime, List<Reservation>>(); // 儲存每個日期對應的預約列表

        private readonly string dataFilePath = "reservations.json"; // 預約資料儲存的檔案路徑

        public MainForm() // 建構函式，初始化表單
        {
            InitializeComponent(); // 初始化表單元件
            SetupDataGridColumns(); // 設定表格欄位
            SetupTimeRows(); // 設定時間列
            dateTimePickerDate.Value = DateTime.Today; // 預設選擇今天的日期
            RefreshReservationGrid(); // 重新整理表格內容

            dataGridViewReservations.SelectionMode = DataGridViewSelectionMode.CellSelect; // 設定選擇模式為儲存格選擇
            dataGridViewReservations.DefaultCellStyle.SelectionBackColor = dataGridViewReservations.DefaultCellStyle.BackColor; // 移除選擇後的背景色
            dataGridViewReservations.DefaultCellStyle.SelectionForeColor = dataGridViewReservations.DefaultCellStyle.ForeColor; // 移除選擇後的文字色
            dataGridViewReservations.SelectionChanged += (s, e) => dataGridViewReservations.ClearSelection(); // 每次選擇變更後自動取消選擇

            if (File.Exists(dataFilePath)) // 如果資料檔存在
            {
                string json = File.ReadAllText(dataFilePath); // 讀取 JSON 文字
                var loadedData = JsonConvert.DeserializeObject<Dictionary<DateTime, List<Reservation>>>(json); // 反序列化為字典物件
                if (loadedData != null) // 如果載入成功
                {
                    reservationsByDate = loadedData; // 更新內部資料
                }
            }
            RefreshReservationGrid(); // 重新整理表格內容
        }

        private void SaveReservations() // 儲存預約資料到檔案
        {
            string json = JsonConvert.SerializeObject(reservationsByDate, Formatting.Indented); // 將資料序列化為 JSON 格式
            File.WriteAllText(dataFilePath, json); // 寫入檔案
        }

        private void SetupDataGridColumns() // 設定表格欄位
        {
            dataGridViewReservations.Columns.Clear(); // 清空現有欄位
            dataGridViewReservations.Columns.Add("Time", "時間"); // 加入時間欄位

            for (int i = 1; i <= 5; i++) // 建立 5 個座位欄位
            {
                var checkColumn = new DataGridViewCheckBoxColumn(); // 勾選欄位
                checkColumn.Name = $"Seat{i}_Check"; // 欄位名稱
                checkColumn.HeaderText = $"座位 {i}"; // 表頭顯示文字
                checkColumn.Width = 50; // 欄寬
                dataGridViewReservations.Columns.Add(checkColumn); // 加入欄位

                var nameColumn = new DataGridViewTextBoxColumn(); // 預約姓名欄位
                nameColumn.Name = $"Seat{i}_Name"; // 欄位名稱
                nameColumn.HeaderText = $"預約姓名"; // 表頭顯示文字
                nameColumn.Width = 80; // 欄寬
                nameColumn.ReadOnly = true; // 設為唯讀
                dataGridViewReservations.Columns.Add(nameColumn); // 加入欄位
            }
        }

        private void SetupTimeRows() // 設定時間列（從 8:00 到 20:00）
        {
            dataGridViewReservations.Rows.Clear(); // 清空現有列
            for (int hour = 8; hour <= 20; hour++) // 從 8 點到 20 點
            {
                int rowIndex = dataGridViewReservations.Rows.Add($"{hour:00}:00"); // 加入時間列
                for (int seatIdx = 1; seatIdx <= 5; seatIdx++) // 每個座位欄預設值
                {
                    dataGridViewReservations.Rows[rowIndex].Cells[$"Seat{seatIdx}_Check"].Value = false; // 預設未勾選
                    dataGridViewReservations.Rows[rowIndex].Cells[$"Seat{seatIdx}_Name"].Value = ""; // 預設沒有名字
                }
            }
        }

        private void RefreshReservationGrid() // 刷新表格顯示
        {
            DateTime selectedDate = dateTimePickerDate.Value.Date; // 取得選擇的日期

            SetupTimeRows(); // 重建時間列與清空內容

            for (int row = 0; row < dataGridViewReservations.Rows.Count; row++) // 重設欄位背景色與內容
            {
                for (int seatIdx = 1; seatIdx <= 5; seatIdx++)
                {
                    var nameCell = dataGridViewReservations.Rows[row].Cells[$"Seat{seatIdx}_Name"]; // 取得儲存格
                    nameCell.Style.BackColor = Color.White; // 設定背景色為白色
                    nameCell.Value = ""; // 清空內容
                }
            }

            if (reservationsByDate.TryGetValue(selectedDate, out var dayReservations)) // 如果有該日預約資料
            {
                foreach (var res in dayReservations) // 將預約資料填入表格
                {
                    int rowIndex = int.Parse(res.Time.Split(':')[0]) - 8; // 計算列索引（8點對應索引0）
                    int seatIdx = int.Parse(res.Seat.Replace("號", "")); // 取得座位號
                    var nameCell = dataGridViewReservations.Rows[rowIndex].Cells[$"Seat{seatIdx}_Name"]; // 取得儲存格
                    nameCell.Value = res.Name; // 設定預約人名
                    nameCell.Style.BackColor = Color.LightCoral; // 背景色設為淺紅色
                }
            }
        }

        private void btnPrevDay_Click(object sender, EventArgs e) => dateTimePickerDate.Value = dateTimePickerDate.Value.AddDays(-1); // 前一天按鈕事件

        private void btnNextDay_Click(object sender, EventArgs e) => dateTimePickerDate.Value = dateTimePickerDate.Value.AddDays(1); // 後一天按鈕事件

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e) => RefreshReservationGrid(); // 日期變更事件

        private void btnBatchReserve_Click(object sender, EventArgs e) // 批量預約按鈕事件
        {
            string batchName = txtBatchName.Text.Trim(); // 取得預約人名稱
            if (string.IsNullOrEmpty(batchName)) // 如果名稱為空
            {
                MessageBox.Show("請輸入預約人名稱！"); // 顯示提示
                return; // 結束
            }

            DateTime date = dateTimePickerDate.Value.Date; // 取得日期
            if (!reservationsByDate.ContainsKey(date)) // 如果沒有當日資料
                reservationsByDate[date] = new List<Reservation>(); // 建立新資料

            var resList = reservationsByDate[date]; // 取得當日預約列表
            List<string> duplicates = new List<string>(); // 紀錄重複項目

            foreach (DataGridViewRow row in dataGridViewReservations.Rows) // 檢查表格每一列
            {
                string time = row.Cells[0].Value.ToString(); // 取得時間

                for (int seatIdx = 1; seatIdx <= 5; seatIdx++) // 檢查每個座位
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[$"Seat{seatIdx}_Check"].Value); // 是否勾選
                    string seat = $"{seatIdx}號"; // 座位號

                    if (isChecked) // 如果勾選
                    {
                        var existingRes = resList.FirstOrDefault(r => r.Seat == seat && r.Time == time); // 查找是否已存在
                        if (existingRes != null) // 如果存在
                        {
                            duplicates.Add($"座位 {seat}, 時段 {time}, 已預約: {existingRes.Name}"); // 加入重複列表
                        }
                    }
                }
            }

            bool overwrite = false; // 是否強制覆蓋
            if (duplicates.Count > 0) // 如果有重複
            {
                string message = "以下座位已有預約:\n" + string.Join("\n", duplicates) + "\n\n是否強制覆蓋？"; // 顯示訊息
                var result = MessageBox.Show(message, "預約衝突", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2); // 顯示對話框
                if (result == DialogResult.Yes) // 如果選擇 Yes
                    overwrite = true; // 設定為覆蓋
                else
                    return; // 否則結束
            }

            foreach (DataGridViewRow row in dataGridViewReservations.Rows) // 執行預約
            {
                string time = row.Cells[0].Value.ToString(); // 取得時間

                for (int seatIdx = 1; seatIdx <= 5; seatIdx++) // 每個座位
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[$"Seat{seatIdx}_Check"].Value); // 是否勾選
                    string seat = $"{seatIdx}號"; // 座位號

                    if (isChecked) // 如果勾選
                    {
                        var existingRes = resList.FirstOrDefault(r => r.Seat == seat && r.Time == time); // 查找現有項
                        if (existingRes != null) // 如果存在
                        {
                            if (overwrite) // 如果要覆蓋
                            {
                                existingRes.Name = batchName; // 更新名稱
                                row.Cells[$"Seat{seatIdx}_Name"].Value = batchName; // 更新表格
                            }
                        }
                        else
                        {
                            resList.Add(new Reservation { Seat = seat, Time = time, Name = batchName }); // 新增預約
                            row.Cells[$"Seat{seatIdx}_Name"].Value = batchName; // 更新表格
                        }
                    }
                }
            }

            RefreshReservationGrid(); // 刷新表格
            SaveReservations(); // 儲存資料
        }

        private void btnBatchDelete_Click(object sender, EventArgs e) // 批量刪除按鈕事件
        {
            DateTime date = dateTimePickerDate.Value.Date; // 取得日期
            if (!reservationsByDate.ContainsKey(date)) return; // 沒有資料則結束

            var resList = reservationsByDate[date]; // 取得預約列表
            List<string> toDeleteList = new List<string>(); // 紀錄要刪除的項目

            foreach (DataGridViewRow row in dataGridViewReservations.Rows) // 檢查每一列
            {
                string time = row.Cells[0].Value.ToString(); // 取得時間

                for (int seatIdx = 1; seatIdx <= 5; seatIdx++) // 每個座位
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[$"Seat{seatIdx}_Check"].Value); // 是否勾選
                    string seat = $"{seatIdx}號"; // 座位號

                    if (isChecked) // 如果勾選
                    {
                        var resToRemove = resList.FirstOrDefault(r => r.Seat == seat && r.Time == time); // 查找預約
                        if (resToRemove != null) // 如果存在
                        {
                            toDeleteList.Add($"座位 {seat}, 時段 {time}, 預約人: {resToRemove.Name}"); // 加入刪除列表
                        }
                    }
                }
            }

            if (toDeleteList.Count == 0) // 沒有項目要刪
            {
                MessageBox.Show("沒有找到要刪除的預約！"); // 顯示提示
                return; // 結束
            }

            string message = "以下預約將被刪除:\n" + string.Join("\n", toDeleteList) + "\n\n是否確定刪除？"; // 顯示確認訊息
            var result = MessageBox.Show(message, "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2); // 顯示對話框
            if (result != DialogResult.Yes) // 如果不是 Yes
            {
                return; // 結束
            }

            foreach (DataGridViewRow row in dataGridViewReservations.Rows) // 執行刪除
            {
                string time = row.Cells[0].Value.ToString(); // 取得時間

                for (int seatIdx = 1; seatIdx <= 5; seatIdx++) // 每個座位
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[$"Seat{seatIdx}_Check"].Value); // 是否勾選
                    string seat = $"{seatIdx}號"; // 座位號

                    if (isChecked) // 如果勾選
                    {
                        var resToRemove = resList.FirstOrDefault(r => r.Seat == seat && r.Time == time); // 查找預約
                        if (resToRemove != null) // 如果存在
                        {
                            resList.Remove(resToRemove); // 從列表移除
                            row.Cells[$"Seat{seatIdx}_Name"].Value = ""; // 清空表格
                            row.Cells[$"Seat{seatIdx}_Name"].Style.BackColor = Color.White; // 重設背景色
                        }
                    }
                }
            }

            RefreshReservationGrid(); // 刷新表格
            SaveReservations(); // 儲存資料
        }

        private void btnClearSelection_Click(object sender, EventArgs e) // 清除勾選按鈕事件
        {
            foreach (DataGridViewRow row in dataGridViewReservations.Rows) // 每一列
            {
                for (int seatIdx = 1; seatIdx <= 5; seatIdx++) // 每個座位
                {
                    var cell = row.Cells[$"Seat{seatIdx}_Check"]; // 取得勾選欄位
                    if (cell is DataGridViewCheckBoxCell) // 如果是勾選欄
                    {
                        cell.Value = false; // 取消勾選
                    }
                }
            }
        }

        private void dataGridViewReservations_CellContentClick(object sender, DataGridViewCellEventArgs e) // 表格內容點擊事件（目前未使用）
        {

        }

        private void label1_Click(object sender, EventArgs e) // 標籤點擊事件（目前未使用）
        {

        }
    }

    public class Reservation // 預約資料類別
    {
        public string Seat { get; set; } // 座位號
        public string Time { get; set; } // 時段
        public string Name { get; set; } // 預約人名
    }
}
