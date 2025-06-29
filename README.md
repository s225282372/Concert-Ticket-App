# 🎟️ Concert Ticket App

This is a C# console-based ticketing system that showcases real-world application of software design patterns by simulating ticket purchases, enhancements, and analytics for music concerts and events.

---

## 📖 Scenario Overview

The **Concert Ticket App** allows users to purchase standard concert tickets and enhance them with premium experiences such as:

- 🎫 **VIP Access**  
- 🤝 **Meet & Greet Opportunities**  
- 🪑 **Premium Seating**

The system processes transactions, logs analytics, and offers a modular, pattern-based structure.

---

## 🧠 Design Patterns Used

### 🔁 Singleton Pattern – Analytics Tracker  
Ensures a single, centralized instance of `AnalyticsTracker` for consistent data collection across the system. It logs:
- Sales events
- Total revenue
- Transaction history

### 🎨 Decorator Pattern – Ticket Enhancements  
Allows dynamic upgrades to standard tickets without altering the base ticket class:
- Flexible pricing and service composition
- Example: `StandardTicket` → `VIPDecorator` → `MeetGreetDecorator`

### 📦 Command Pattern – Purchase Flow  
Encapsulates ticket purchasing logic:
- Supports `Execute()` and `Undo()` operations
- Tracks purchase history
- Cleanly separates business logic

---

## 🛠 Technologies

- 💻 **Language**: C#
- ⚙️ **Framework**: .NET
- 🧱 **IDE**: Visual Studio 2022
- 📐 **Concepts**: OOP, Interfaces, Abstraction, Encapsulation

---

## 🎮 Demo Flow

- Initializes analytics tracker (singleton)
- Builds and decorates tickets dynamically
- Executes ticket purchase commands
- Logs analytics and supports undo
- Demonstrates independence of patterns

---

## 📊 Sample Output

```
VIP Upgrade: Standard Ticket - Rock Concert at MSG + VIP Access
Total Price: R225.00

Processing ticket purchase...
Customer ID: 67890
Ticket: VIP Ticket + Meet & Greet
Total Price: R375.00

Undoing last command...
Final Analytics Report:
- Total Sales: 3
- Total Revenue: R735.00
```

---

## 📄 License

This project is for educational purposes and is part of the university assignment.

## 👨‍💻 Author

**Maselaelo Glen**  
Final-Year Software Engineering Student

---
