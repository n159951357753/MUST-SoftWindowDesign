using System;  // 匯入 System 命名空間，提供基本功能（如 Console、DateTime 等）
using System.Collections.Generic;  // 匯入泛型集合命名空間，用於 List、Dictionary 等
using System.Linq;  // 匯入 LINQ 命名空間，提供資料查詢功能
using System.Threading.Tasks;  // 匯入多執行緒與非同步作業命名空間
using System.Windows.Forms;  // 匯入 Windows 視窗表單應用程式命名空間

namespace KStudyCenterAdmin  // 定義命名空間 KStudyCenterAdmin，用來組織程式碼
{
    internal static class Program  // 定義內部靜態類別 Program，作為主程式進入點
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]  // 指定應用程式使用單執行緒單元模型（必要於 Windows Forms）
        static void Main()  // 定義 Main 方法，應用程式執行的起點
        {
            Application.EnableVisualStyles();  // 啟用視覺樣式，讓表單和控制項使用目前 Windows 主題
            Application.SetCompatibleTextRenderingDefault(false);  // 設定文字渲染為 GDI（false）而非 GDI+（true），避免兼容性問題
            Application.Run(new MainForm());  // 執行主視窗 MainForm，開始事件循環（message loop）
        }
    }
}
