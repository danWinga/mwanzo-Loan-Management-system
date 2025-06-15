# 💰 Mwangaza Loan Management System

`Mwangaza LMS` is a lightweight desktop-based loan tracking solution built for small to mid-size SACCOs and microfinance institutions. It streamlines customer registration, loan issuance, repayment tracking, penalty application, and reporting — all in one integrated system.

> 🏦 Built with .NET Framework (WinForms/C#)

---

## 🎯 Key Features

- 🧾 Member registration and profile management
- 💳 Loan application, approval workflow, and disbursement
- 🔁 Automated repayment tracking and amortization
- ⚠️ Penalty engine for overdue loans
- 📊 Financial summaries, printable receipts & reports
- 🔐 Admin user controls and audit logs

---

## 🛠️ Technology Stack

| Layer       | Tech             |
|------------|------------------|
| Language    | C# (.NET Framework) |
| Interface   | Windows Forms    |
| Storage     | SQL Server / MS Access |
| Reports     | Crystal Reports / RDLC |

---

## 🗃️ Project Structure

```
mwanzoLoanManagementSystem/
├── mwanzoBarakaSystem/         # Source code and forms
│   ├── Forms/                  # UI components
│   ├── Models/                 # Data models
│   └── Services/               # Business logic
├── mwanzoBarakaSystem.sln     # Visual Studio solution file
├── README.md
```

---

## 📸 Sample UI

> *(Example login or dashboard preview)*

![Login UI](bcf55e69-c774-4720-a46b-b9cd1a865f11.png)

---

## 🧪 Running the App (Dev Mode)

### Requirements:
- Visual Studio (2015+)
- .NET Framework 4.6 or later
- SQL Server Express or MS Access

### Steps:
1. Clone the repo
```bash
git clone https://github.com/danWinga/mwanzo-Loan-Management-system.git
```
2. Open `mwanzoBarakaSystem.sln` in Visual Studio
3. Configure DB connection string inside `App.config`
4. Build & run (`F5`)

---

## 🧾 Sample Features in Action

- ✅ Register a new customer with photo
- ✅ Approve a loan and auto-generate repayment schedule
- ✅ Record a repayment and auto-update balances
- ✅ Print receipt & generate loan summary PDF
- ✅ Admin views audit logs and export data

---

## 🔐 Security
- Admin panel for user management
- Basic authentication
- Role-based access control planned in future

---

## 🧠 Author
**Daniel Ooro Winga**  
Software Developer | Automation & Finance Systems  
[LinkedIn](https://www.linkedin.com/in/daniel-winga-8b910032) | [GitHub](https://github.com/danWinga)

---

## 📜 License
MIT © 2025 Daniel Ooro Winga
