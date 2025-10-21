# Observer Design Pattern (C#)

This project demonstrates the **Observer Design Pattern** implemented in C#.  
It simulates a simple event-driven notification system where multiple subscribers are automatically notified when a specific event occurs.

## 🧠 Concept

The **Observer Pattern** defines a one-to-many dependency between objects so that when one object (the *subject*) changes state, all its dependents (the *observers*) are notified and updated automatically.

## ⚙️ Implementation Overview

- **Subject (OnlineMarketplace):**
  Manages products, offers, and subscribers.  
  Notifies observers when new events (e.g., product added or offer created) occur.

- **Observer (Subscriber / User):**
  Listens for updates and receives notifications from the subject.

- **Events (EventType Enum):**
  Defines types of notifications:  
  `NEW_PRODUCT`, `NEW_OFFER`, `JOB_OPENING`, etc.

- **Interfaces (ISubscriber):**
  Defines the contract for all subscribers (the `Notify()` method).

## 🧩 Structure

observer-design-pattern/
│
├── Entities/
│ ├── OnlineMarketplace.cs
│ ├── Product.cs
│ ├── Offer.cs
│ └── User.cs
│
├── Enums/
│ └── EventType.cs
│
├── Interfaces/
│ └── Subscriber.cs
│
├── Program.cs
└── README.md



## 🚀 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/MohamedAftah004/observer-design-pattern.git
