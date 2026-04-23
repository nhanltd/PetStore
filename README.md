# PetStore E-Commerce Web Application

## Overview

PetStore is a full-stack e-commerce web application developed using **ASP.NET Core MVC** following the **Model-View-Controller (MVC)** architectural pattern. The system is designed to simulate a modern online pet shop where customers can browse products, manage shopping carts, place orders, and perform account-related operations.

The application uses **Entity Framework Core (EF Core)** as the Object-Relational Mapper (ORM) and **Microsoft SQL Server** as the relational database management system.

This project demonstrates practical implementation of:

- MVC Architecture  
- CRUD Operations  
- Database Design and Relationships  
- Authentication and Authorization  
- E-Commerce Workflow  
- Session Management  
- SQL Server Integration using EF Core

---

# Tech Stack

## Backend
- ASP.NET Core MVC  
- C#  
- Entity Framework Core  
- LINQ  

## Frontend
- HTML5  
- CSS3  
- Bootstrap  
- JavaScript  
- Razor Views

## Database
- SQL Server

---

# Features

## Customer Features
- Browse products  
- Search products  
- Add to cart  
- Checkout  
- View order history  
- User login and registration  

## Admin Features
- Product CRUD  
- Category Management  
- Inventory Management  
- Order Management  

---

# Database Design

## Products Table

| Column | Type |
|--------|------|
| ProductId | int |
| Name | nvarchar |
| Price | decimal |
| Description | nvarchar |
| StockQuantity | int |
| CategoryId | int |

## Categories Table

| Column | Type |
|--------|------|
| CategoryId | int |
| CategoryName | nvarchar |

## Orders Table

| Column | Type |
|--------|------|
| OrderId | int |
| CustomerId | int |
| OrderDate | datetime |
| TotalAmount | decimal |

---

# Install Required Packages

```powershell
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.EntityFrameworkCore.Design
