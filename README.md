# E-Commerce Platform Architecture Overview

## System Architecture Diagram

```
┌─────────────────────────────────────────────────────────────────┐
│                        CLIENT LAYER                             │
├─────────────────────────────────────────────────────────────────┤
│  React Frontend (Port 3000)                                     │
│  ├── Components (UI Elements)                                   │
│  ├── Pages (Route Components)                                   │
│  ├── Redux Store (State Management)                             │ 
│  ├── Services (API Calls)                                       │
│  └── Utils (Helper Functions)                                   │
└─────────────────────────────────────────────────────────────────┘
                                │ HTTPS/REST API
                                ▼
┌─────────────────────────────────────────────────────────────────┐
│                      API GATEWAY LAYER                          │
├─────────────────────────────────────────────────────────────────┤
│  ASP.NET Core API (Port 7000)                                   │
│  ├── Controllers (HTTP Endpoints)                               │
│  ├── Middleware (Auth, CORS, Logging)                           │
│  ├── JWT Authentication                                         │
│  └── Swagger Documentation                                      │
└─────────────────────────────────────────────────────────────────┘
                                │ Service Calls
                                ▼
┌─────────────────────────────────────────────────────────────────┐
│                     BUSINESS LOGIC LAYER                        │
├─────────────────────────────────────────────────────────────────┤
│  ┌─────────────────┐ ┌─────────────────┐ ┌─────────────────┐    │
│  │ Authentication  │ │ Product Service │ │  Cart Service   │    │
│  │    Service      │ │                 │ │                 │    │
│  └─────────────────┘ └─────────────────┘ └─────────────────┘    │
│  ┌─────────────────┐ ┌─────────────────┐                        │ 
│  │ Order Service   │ │ Payment Service │                        │
│  │                 │ │                 │                        │
│  └─────────────────┘ └─────────────────┘                        │
└─────────────────────────────────────────────────────────────────┘
                                │ Entity Framework
                                ▼
┌─────────────────────────────────────────────────────────────────┐
│                       DATA ACCESS LAYER                         │
├─────────────────────────────────────────────────────────────────┤
│  Entity Framework Core                                          │
│  ├── DbContext (Database Context)                               │
│  ├── Models (Entity Classes)                                    │
│  ├── Migrations (Schema Changes)                                │
│  └── Repository Pattern                                         │
└─────────────────────────────────────────────────────────────────┘
                                │ SQL Connection
                                ▼
┌─────────────────────────────────────────────────────────────────┐
│                        DATABASE LAYER                           │
├─────────────────────────────────────────────────────────────────┤
│  SQL Server Database                                            │
│  ├── Users Table                                                │
│  ├── Products Table                                             │
│  ├── Orders Table                                               │
│  ├── OrderItems Table                                           │
│  └── Cart Table                                                 │
└─────────────────────────────────────────────────────────────────┘
```
