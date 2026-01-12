# ESG MCP Server

這是一個基於 **ASP.NET Core 8 Web API** 建立的伺服器，專門用於管理 **ESG**（環境、社會、公司治理）數據以及聯繫人資訊。本專案提供 **RESTful API** 端點，方便開發者存取並管理 SQL Server 資料庫中的使用者、組織架構及相關業務細節。

## 專案概述 (Project Overview)

**ESG MCP Server** 是為了提供強大的 ESG 後端服務而設計。它採用 **Entity Framework Core** 作為資料存取層，並建立了完整的資料模型來處理：

- 使用者帳號與身份驗證 (Authentication)
- 組織架構與部門管理
- ESG 指標與合規數據追蹤
- 聯繫人管理 (Contact Management)
- 各類業務實體與系統配置

## 先決條件 (Prerequisites)

- **.NET 8 SDK** 或更新版本
- **SQL Server**（需配置於 Connection String）
- **Visual Studio 2022** 或任何相容的 .NET IDE

## 技術棧 (Technology Stack)

- **Framework**: ASP.NET Core 8
- **ORM**: Entity Framework Core 8.0.22
- **Database**: SQL Server
- **Language**: C# 12

## 專案結構 (Project Structure)

```text
esg-mcp-server/
├── Controllers/
│   └── ContactController.cs       # 聯繫人管理相關 API 端點
├── Data/
│   ├── DbHcisContext.cs          # Entity Framework DbContext
│   ├── Bauser.cs                 # 使用者模型 (User model)
│   ├── MaiAgentContact.cs        # 聯繫人模型 (Contact model)
│   └── [Other Data Models]       # 其他 ESG 與業務實體模型
├── Models/
│   └── ErrorViewModel.cs         # 錯誤處理視圖模型
├── Program.cs                    # 應用程式啟動與配置中心
├── appsettings.json              # 基礎配置設定
├── appsettings.Development.json  # 開發環境專用設定
└── esg-mcp-server.csproj         # 專案定義檔