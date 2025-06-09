# InventoryManager 庫存管理系統

一套使用 **C# WinForms** 打造的輕量級庫存管理系統，適合中小型團隊日常維護零件庫存，具備圖形化介面、JSON 儲存與完整出入庫歷史紀錄功能。

---

## 🚀 系統特色

- 🧾 **庫存總覽**
  - 顯示低於下限的告警零件
  - 顯示最近 20 筆入/出庫紀錄

- 🛠️ **庫存管理**
  - 支援新增、編輯、入庫、出庫操作
  - 檢查重複編號與資料驗證

- 📜 **歷史紀錄**
  - 所有操作都會自動紀錄時間、備註、操作者
  - 可依關鍵字與日期範圍查詢

- 💾 **資料儲存**
  - 零件資料儲存在 `parts.json`
  - 操作紀錄儲存在 `history.json`
  - 使用 `System.Text.Json` 自動序列化

---

## 🗂️ JSON 資料格式

### `parts.json`
```json
[
  {
    "PartNumber": "A001",
    "PartName": "螺絲",
    "StorageLocation": "櫃1",
    "Quantity": 100,
    "LowerLimit": 20,
    "UpperLimit": 200,
    "Note": "測試用"
  }
]
```

### `history.json`
```json
[
  {
    "Timestamp": "2024-06-09T10:30:00",
    "PartNumber": "A001",
    "OperationType": "入庫",
    "QuantityChanged": 50,
    "Operator": "Admin",
    "Note": "補貨"
  }
]
```

---

## 📷 介面截圖

| 主畫面（三分頁） | 入庫視窗 | 歷史紀錄 |
|------------------|----------|----------|
| ![](screenshots/main_ui.png) | ![](screenshots/stock_in.png) | ![](screenshots/history.png) |

---

## 🧱 專案結構

```
InventoryManager/
├── Form1.cs                 # 主介面（分頁式）
├── FormAddPart.cs          # 新增零件視窗
├── FormEditPart.cs         # 編輯零件視窗
├── FormStockInEdit.cs      # 入庫操作
├── FormStockOutEdit.cs     # 出庫操作
├── parts.json              # 庫存資料檔案
├── history.json            # 歷史紀錄檔案
```

---

## 🛠️ 開發與使用方式

1. 使用 Git 下載本專案
2. 使用 Visual Studio 開啟 `.sln` 檔案
3. 建置並執行專案

> 📦 請確保已透過 NuGet 安裝 `System.Text.Json`

---

## 📌 授權

本專案採用 MIT License 授權，歡迎自由使用與修改。
