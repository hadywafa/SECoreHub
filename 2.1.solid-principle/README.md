# 🧱 **Intro to Design Principles vs Design Patterns in C#**

> Understand how to **think like an architect**, not just code like a developer 💡

---

## 🧠 What Are **Design Principles**?

> Design principles are **general guidelines** for writing **clean, maintainable, and flexible code**. They’re about **how** your code should behave.

✅ They're **language-independent**
✅ They help you **prevent code rot**
✅ Think of them as the **laws of good architecture**

### 🔑 Most Common Principles

- **SOLID** – The five commandments of OOP design
- **DRY** – Don’t Repeat Yourself
- **YAGNI** – You Ain’t Gonna Need It
- **KISS** – Keep It Simple, Stupid
- **Separation of Concerns**
- **Encapsulation** and **Cohesion**

---

## 🧩 What Are **Design Patterns**?

> Patterns are **reusable solutions** to common software design problems.

✅ They solve specific problems
✅ They are **language-agnostic but code-focused**
✅ They’re proven by experience — not theory

### 🔧 Pattern Categories

| Type           | Description                          | Examples                    |
| -------------- | ------------------------------------ | --------------------------- |
| **Creational** | Control object creation              | Singleton, Factory, Builder |
| **Structural** | Manage relationships between objects | Adapter, Decorator, Proxy   |
| **Behavioral** | Handle communication between objects | Strategy, Observer, Command |

---

## 🆚 Design Principles vs Design Patterns

| Aspect   | Design Principles               | Design Patterns                           |
| -------- | ------------------------------- | ----------------------------------------- |
| Purpose  | Guide how to **structure** code | Solve **specific architectural problems** |
| Scope    | Broad guidelines                | Concrete, reusable implementations        |
| Examples | SOLID, DRY, KISS                | Singleton, Factory, Strategy, Adapter     |
| Analogy  | Traffic laws 🚦                 | Vehicle blueprints 🚗                     |
| Goal     | Prevent bad design 🛡️           | Provide reusable good design 🛠️           |

---

## 🎯 Real-World Analogy

- **Design Principles** = Rules of good driving (stay in lane, use turn signals)
- **Design Patterns** = The models of cars and tools (sedan, SUV, GPS)

They **work together** to make you a better software engineer.

---

## 💬 Interview Insight

> "Principles guide how we think about code quality and structure. Patterns are blueprints for solving problems. Good developers use principles by habit and patterns when needed."

---

## 📚 What's Next?

Now that we’ve set the foundation, let’s begin with the **heart of object-oriented design**:

---

## 🔥 SOLID Principles in **C#**

> The gold standard for maintainable, scalable, and loosely-coupled code.

## 🧠 What is SOLID?

| Letter | Principle Name                  | Description                                 |
| ------ | ------------------------------- | ------------------------------------------- |
| S      | Single Responsibility Principle | One class = One job                         |
| O      | Open/Closed Principle           | Open for extension, closed for modification |
| L      | Liskov Substitution Principle   | Subtypes must behave like their base        |
| I      | Interface Segregation Principle | No fat interfaces                           |
| D      | Dependency Inversion Principle  | Depend on abstractions, not concretions     |
