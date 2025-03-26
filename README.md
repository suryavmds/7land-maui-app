# 7LAND - E-Commerce Mobile Application

![.NET MAUI](https://img.shields.io/badge/.NET%20MAUI-512BD4?logo=.net&logoColor=white)
![Firebase](https://img.shields.io/badge/Firebase-FFCA28?logo=firebase&logoColor=black)
![RazorPay](https://img.shields.io/badge/RazorPay-00B9F1?logo=razorpay&logoColor=white)

## 📝 Table of Contents
- [Project Overview](#-project-overview)
- [Features](#-features)
- [Tech Stack](#-tech-stack)
- [Models](#-models)
- [Getting Started](#-getting-started)
- [Team](#-team)
- [License](#-license)

## 🌟 Project Overview
7LAND is a lightweight e-commerce solution built with .NET MAUI that enables:
- Admin product management
- Guest checkout functionality
- Secure payments via RazorPay
- Cross-platform support (Android/iOS)

## 👥 Team Members
| Name | Student ID |
|---------|-------------|
| **Surya Prakash Vadivel** | A00315079 |
| **Soundhar Keerambur Kanagarajan** | A00315076 |

## 🛠 Tech Stack
**Frontend:**  
.NET MAUI (Cross-platform framework)

**Backend Services:**  
- Firebase Authentication
- Firebase Realtime Database
- Firebase Storage

**Payment Gateway:**  
RazorPay API

## 🗂 Models
```csharp
// Product.cs
public class Product
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public decimal MaximumPrice { get; set; }
    public int StockQuantity { get; set; }
    public string ImageUrl { get; set; }
}
```
```csharp
// Order.cs
public class Order
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public List<Product> Products { get; set; } = new();
    public decimal TotalAmount { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public bool IsPaid { get; set; }
}
```

# 🚀 Getting Started

## Prerequisites
- .NET 8 SDK
- Visiual Syudio Code with C# Dev Kit
- Android EMulator (via Android Studio)

## Installation
1. Clone the repository:

    ```bash
    git clone https://github.com/suryavmds/7land-maui-app.git
    ```

2. Navigate to project directory:
    ```bash
    cd SevenLand
    ```
3. Restore dependencies:
    ```bash
    dotnet restore
    ```
4. Build for Android:
    ```bash
    dotnet build -f net8.0-android
    ```
5. Run on Android:
    ```bash
    dotnet run -f net8.0-android
    ```