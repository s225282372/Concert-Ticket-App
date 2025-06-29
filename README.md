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
CONCERT TICKET APP DEMONSTRATION

1. SINGLETON PATTERN - Analytics Tracker
=========================================
Same instance? True
Analytics system initialized and ready to track events.

2. DECORATOR PATTERN - Ticket Upgrades
=========================================
Base Ticket 1: Standard Ticket - Rock Concert at Madison Square Garden
Price: R75.00

VIP Upgrade: Standard Ticket - Rock Concert at Madison Square Garden + VIP Access (Premium Seating, Express Entry, Complimentary Drinks)
Price: R225.00

Premium Package: Standard Ticket - Pop Festival at Central Park + VIP Access (Premium Seating, Express Entry, Complimentary Drinks) + Meet & Greet (Photo Opportunity, Autograph Session, Backstage Access)
Price: R440.00

3. COMMAND PATTERN - Purchase Flow
=========================================

Processing ticket purchase...
Transaction ID: 100
Customer ID: 12345
Ticket: Standard Ticket - Rock Concert at Madison Square Garden
Total Price: R75.00
Payment processed successfully!
Ticket details:  Customer: 12345, Ticket: Standard Ticket - Rock Concert at Madison Square Garden, Amount: R75.00

Processing ticket purchase...
Transaction ID: 101
Customer ID: 67890
Ticket: Standard Ticket - Rock Concert at Madison Square Garden + VIP Access (Premium Seating, Express Entry, Complimentary Drinks)
Total Price: R225.00
Payment processed successfully!
Ticket details:  Customer: 67890, Ticket: Standard Ticket - Rock Concert at Madison Square Garden + VIP Access (Premium Seating, Express Entry, Complimentary Drinks), Amount: R225.00

Processing ticket purchase...
Transaction ID: 102
Customer ID: 11111
Ticket: Standard Ticket - Pop Festival at Central Park + VIP Access (Premium Seating, Express Entry, Complimentary Drinks) + Meet & Greet (Photo Opportunity, Autograph Session, Backstage Access)
Total Price: R440.00
Payment processed successfully!
Ticket details:  Customer: 11111, Ticket: Standard Ticket - Pop Festival at Central Park + VIP Access (Premium Seating, Express Entry, Complimentary Drinks) + Meet & Greet (Photo Opportunity, Autograph Session, Backstage Access), Amount: R440.00

Command History: 3 commands executed

4. COMMAND UNDO DEMONSTRATION
=========================================
Undoing last command...
Transaction ID: 102
Reversing purchase for customer 11111
Purchase successfully reversed!

Undoing another command...
Transaction ID: 101
Reversing purchase for customer 67890
Purchase successfully reversed!

5.ANALYTICS REPORT (SINGLETON)
=========================================
Total Sales: 3
Total Revenue: R740.00
Sales Records: 3
=========================================
```

---

## 📄 License

This project is for educational purposes and is part of the university assignment.

## 👨‍💻 Author

**Maselaelo Glen**  
Final-Year Software Engineering Student

---
