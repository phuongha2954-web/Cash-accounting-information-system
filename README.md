# Cash Accounting Information System (CAIS)

## 📌 Project Overview
This project focuses on analyzing and designing a comprehensive web-based **Cash Accounting Information System** tailored for enterprise financial operations. The system bridges the gap between accounting regulations and technical execution, aimed at transforming manual voucher processing into an automated, real-time workflow.

By streamlining cash tracking and general ledger updates, the system significantly improves operational efficiency, eliminates manual data-entry errors, and enhances accounting data integrity.

---

## 👩‍💼 My Role: Business Analyst / System Designer
As the sole BA and System Designer for this graduation project, I was responsible for end-to-end system analysis, functional design, and quality assurance, including:
- **Requirement Engineering:** Gathered business requirements and analyzed accounting workflows to define detailed functional specifications.
- **System Architecture & Modeling:** Designed **20+ UML diagrams** to structure system behaviors and database structures.
- **Process Automation Design:** Proposed **automated accounting entry logic** and real-time ledger synchronization.
- **Quality Assurance:** Developed and executed **65+ test cases** to validate workflow accuracy and financial reporting correctness.

---

## 🎯 System Core Objectives
- **Automated Entry Logic:** Automatically generate corresponding Debit/Credit account entries based on pre-defined transaction categories, reducing manual accounting slip errors.
- **Real-time Synchronization:** Instantly update cash books, ledgers, and financial summaries as soon as a transaction voucher is approved.
- **Internal Control & Security:** Establish strict multi-level approval workflows for cash vouchers and implement a matrix permission system.
- **Compliance Reporting:** Support the automated generation of legally compliant cash journals, general ledgers, and financial summaries.

---

## 🛠 Tools & Technologies
- **Business Analysis & Modeling:** Draw.io (UML Diagrams, Workflow Architecture)
- **Database Architecture:** SQL Server (ERD design, Relational database structure, Data query)
- **System Framework:** ASP.NET MVC, C# (Object-Oriented system thinking, Web-based architecture design)
- **Documentation & Reporting:** Microsoft Excel (Test case matrices, Master data modeling)

---

## 📊 Functional Modules
The system architecture consists of **6 core modules**, working cohesively to handle enterprise cash workflows:

| Module | Key Functions & BA Analytical Focus |
|---|---|
| **System Management** | Handles user authentication, security logs, and **Matrix Permissions** (e.g., Accountant vs. Chief Accountant approval rights). |
| **Category Management** | Manages **Master Data** including chart of accounts (TK 111, TK 112), corporate partners, and standardized transaction reasons. |
| **Opening Balance Management**| Initializes beginning balances for accounting periods, ensuring data consistency before a new fiscal cycle begins. |
| **Transaction Management** | Core engine managing cash receipts/payments and voucher processing with integrated **Automated Entry Logic**. |
| **Book Management** | Automatically records and maintains accounting books, general journals, and real-time transaction history. |
| **Reporting Management** | Dynamically aggregates data to generate real-time accounting reports and accurate financial summaries. |

---

## 📐 UML Diagrams & System Architecture
*All diagrams are fully detailed inside the `diagrams` file.*

### 🔹 Use Case Diagram
- **Analytical Focus:** Defined system boundaries and interactive roles for **4 key actors**: *Accountant (Lập phiếu), Chief Accountant (Kiểm tra), Director (Phê duyệt), and Auditor (Xem báo cáo)*.
- **Key Use Cases:** Voucher Creation, Multi-stage Approval Workflow, Real-time Reporting.

### 🔹 Activity & Sequence Diagrams
- **Voucher Approval Flow:** Modeled the sequence of data passing from the UI Layer through the Controller Logic (checking balance thresholds to prevent negative cash balance exceptions) down to the Database Layer.
- **Real-time Ledger Update:** Visualized the automated background triggers that update book ledgers simultaneously upon voucher validation.

### 🔹 Database ERD (Entity Relationship Diagram)
- Optimized a relational database structure with strict foreign key constraints linking `Transactions`, `Vouchers`, `Accounts_Dictionary`, and `Users` to ensure absolute transactional integrity.

---

## 🖥 UI/UX Mockups
- Designed clean, user-friendly forms for voucher entries with automated dropdown data pulled from Master Data categories.
- Features dynamic dashboards for the **Reporting Management** module to visualize real-time cash flow statuses.

---

## 🧪 Testing & User Acceptance Testing (UAT)
To ensure the system's logic and reliability, a comprehensive test plan with **65+ test cases** was executed:
- **Business Logic Testing:** Verified that automated journal entries correctly mapped Debit/Credit rules for over 15+ different cash transaction scenarios.
- **Exception/Edge Case Handling:** Tested system reactions when attempting to approve a payment voucher that exceeded the current opening balance (System correctly blocked transaction and raised an alert).
- **Data Integrity Testing:** Validated that database tables correctly rolled back transactions if an error occurred mid-process (ACID compliance).

---

## 📚 Key Learnings & Deliverables
- **Academic Achievement:** Secured an **Excellent Grade (Điểm Giỏi)** for the graduation thesis at the Academy of Finance.
- **BA Competencies:** Sharpened skills in translating complex financial regulations into clear, structured software functional specifications (SRS) and visual UML models.
- **System Thinking:** Mastered the end-to-end Software Development Life Cycle (SDLC), from initial requirement gathering to comprehensive UAT design.

---

## 📬 Contact & Deliverables Artifacts
- **Project Documentation:** Complete specification documents and test plans can be found in the [`/Documents`](./Documents) folder.
- **Email:** phuongha2954@gmail.com
- **LinkedIn:** [linkedin.com/in/hatruong2004](https://www.linkedin.com/in/hatruong2004/)
