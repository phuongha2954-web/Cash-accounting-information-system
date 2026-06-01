# Cash Accounting Information System (CAIS) at FPT IS

## 📌 Project Overview
This project focuses on analyzing, designing, and building a comprehensive web-based **Cash Accounting Information System (CAIS)** tailored for the financial operations at **FPT IS Company Limited**. Developed in compliance with the **Circular 99/2025/TT-BTC** accounting regulations, the system bridges the gap between financial compliance and automated software execution.

The system streamlines enterprise cash management by transforming manual voucher processing into an automated, real-time workflow, minimizing data-entry errors, and resolving data latency in multi-unit tracking.

---

## 👩‍💼 My Role: Business Analyst / System Designer
As the author of this graduation thesis project, I managed the complete end-to-end system analysis and design lifecycle, including:
- **Requirement Analysis:** Surveyed real-world cash receipt/payment and bank deposit workflows at FPT IS to establish functional and non-functional specifications.
- **System Modeling:** Modeled system boundaries, actor interactions, and business workflows by creating **20+ UML diagrams**.
- **Database Engineering:** Designed and structured a normalized relational database schema scaled for high-volume enterprise financial records.
- **Quality Assurance:** Authored a comprehensive test plan and executed **65 test cases** (Unit, Integration, System, and Regression testing).

---

## 🎯 Core System Capabilities
- **Automated Entry Logic:** Implemented pre-defined Debit/Credit mapping rules for over 15 transaction scenarios (e.g., cash sales, vendor payments, advances), reducing manual slip entry errors.
- **Real-time Book Synchronization:** Automatically posts approved vouchers to General Ledgers, Cash Journals, and Cash Books, recalculating ledger balances instantly.
- **Internal Control & Multi-Level Approval:** Enforced strict multi-stage digital approval workflows involving Accountants, Chief Accountants, and Directors to eliminate negative cash balance risks.
- **Firm Banking Connection Capability:** Modeled to interface with electronic banking statements (GiayBao) for automated bank reconciliation.

---

## 🛠 Tools & Technologies
- **Methodology:** Object-Oriented Analysis and Design (OOAD) with Unified Modeling Language (UML).
- **Modeling & Design:** Draw.io (Use Case, Class, Sequence, and Activity Diagrams).
- **Database Architecture:** Microsoft SQL Server (3NF Normalization, Relations, Stored Procedures, and Indexes).
- **Development Framework:** ASP.NET MVC, C#.
- **Frontend UI:** HTML5, CSS3, JavaScript, Bootstrap Framework.
- **Documentation:** Microsoft Excel (Test case matrices and master data dictionary configuration).

---

## 📊 Functional Modules & Architecture
The system consists of **6 functional modules** optimized to manage enterprise cash workflows seamlessly:

| Module | Technical & Functional Description |
|---|---|
| **System Management** | Handles secure user authentication, multi-factor login sessions, and **Matrix Permissions** (assigning roles: Administrator, Accountant, Chief Accountant). |
| **Category Management** | Centralizes **Master Data Management** for chart of accounts (TK 111, 112), business partners (customers, vendors, employees), exchange rates, and linked banks. |
| **Opening Balance Management** | Initializes beginning asset balances for accounting periods, guaranteeing data consistency before initiating a new fiscal cycle. |
| **Transaction Management** | Executes core accounting transactions by generating cash receipts, cash payments, bank debit/credit notes, and automated entries. |
| **Book Management** | Automatically compiles and maintains chronological transaction records, general journals, and cash ledgers. |
| **Reporting Management** | Dynamically aggregates database calculations to generate dynamic reports like cash flow summaries, quick dashboards, and statutory financial reports. |

---

## 📐 UML Diagrams & Database Schema
*Full visual models and detailed functional specifications are compiled within the `/Documents` directory.*

### 🔹 Use Case Modeling
- **General Boundaries:** Modeled system access across **4 distinct actors**: *Accountant (Lập phiếu), Chief Accountant (Kiểm tra), Director (Phê duyệt), and Auditor (Xem báo cáo)*.
- **Core Diagrams:** Use Case structures for System Management, Category Configurations, Voucher Processing, Ledger Book Management, and Financial Reporting.

### 🔹 Behavioral Modeling (Sequence & Activity)
- **Voucher Lifecycles:** Sequence diagrams map out the end-to-end data transfer layout from the UI Layer through the Controller Logic (validating balance thresholds to prevent negative fund anomalies) down to the SQL Database Layer.
- **User Workflows:** Activity diagrams explicitly detail the step-by-step logic for data creation, modifications, backup operations, data recovery, and ledger reports generation.

### 🔹 Database Physical Schema (Core Tables)
The underlying database design consists of heavily linked relational tables enforced with strict foreign key constraints to support data integrity:
- `NguoiDung`: Manages account credentials and permission scopes.
- `DMTK`: Maps out account Hierarchies (MaTK, TenTK, CapTK, TKCapTren).
- `DMDT`: Stores details for business partners linked by `NhomDT`.
- `TaiKhoanNH` & `NganHang`: Handles company bank account references.
- `BangTyGia` & `DMTienTe`: Handles exchange rate calculations for foreign currencies.
- `PhieuTC` / `GiayBao` / `PhieuKT`: Acts as header tables for transactions.
- `CTPhieu`: Handles transactional line items (Id, SoCT, TkNo, TkCo, SoTien, SoTienNT).
- `BBKK` & `CTBBKK`: Evaluates actual physical inventory cash audits.

---

## 🧪 Quality Assurance & Verification (UAT)
A rigorous testing phase composed of **65 distinct test cases** was successfully executed to evaluate business logic accuracy:

- **Unit Testing (20 Cases):** Validated individual module functionalities independently with a 100% success rate.
- **Integration Testing (20 Cases):** Evaluated relational constraint mapping across foreign key dependencies (e.g., matching line details back to primary transaction headers).
- **System & UAT Testing (15 Cases):** Simulated comprehensive business scenarios including workflow tracking from early payment requests up to formal cashier disbursements and bookkeeping ledger updates.
- **Exception & Edge Case Auditing:** Verified that system triggers successfully throw alerts and block transaction validations when a payment request exceeds active opening asset balances.

### 📈 Testing Performance Metrics
- **Total Test Cases Executed:** 65
- **Passed Cases:** 58 | **Failed Cases:** 7 (Minor UI anomalies & input data edge cases, all resolved)
- **Final Success Rate:** 89.2% (Meeting project criteria for production deployment)

---

## 📚 Project Outcomes & Key Takeaways
- **Academic Standard:** Awarded an **Excellent Grade ** by the defense council at the Academy of Finance.
- **BA Proficiency:** Proven capability in capturing complex corporate accounting processes and translating them into structured, reliable software specifications and technical diagrams.
- **SDLC Comprehension:** Mastered the structural phases of the Software Development Life Cycle, ensuring a cohesive fit between functional business goals and back-end database engines.

---

## 📬 Contact & Artifacts Directory
- **Project Artifacts:** Full text specification papers, relational schemas, and comprehensive test case logs are securely categorized in the [`/docs`](./docs) repository directory.
- **Email:** phuongha2954@gmail.com
- **LinkedIn:** [linkedin.com/in/hatruong2004](https://www.linkedin.com/in/hatruong2004/)
