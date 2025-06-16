# 📦 安裝說明（INSTALL.md）

本專案為 Windows Forms 桌面應用程式，開發語言為 C#，建議使用 Visual Studio 進行開發與執行。

---

## ✅ 系統需求

- 作業系統：Windows 10 / 11
- 開發環境：Visual Studio 2019 / 2022
- .NET Framework：4.7.2 或更新版本
- 套件管理：NuGet（自動安裝缺少套件）

---

## 🛠️ 安裝步驟

1. 下載本專案或使用 Git 進行 Clone：

```bash
git clone https://github.com/n159951357753/期末專題報告2-庫存管理系統.git
```

2. 使用 Visual Studio 開啟 `.sln` 解決方案檔。

3. 還原 NuGet 套件（首次開啟時會自動還原）

4. 編譯並執行專案（預設為 WinForms GUI）

---

## 📁 資料夾結構簡述

- `src/`：主要程式碼與資源
- `screenshots/`：README 使用的截圖
- `LICENSE`：MIT 授權條款
- `README.md`：專案說明
- `INSTALL.md`：本文件

---

## 📌 注意事項

- 若出現權限或載入資源錯誤，請確保以管理員模式執行 Visual Studio
- 若有外部 DLL 或資源請放入 `src/Libs/` 內

