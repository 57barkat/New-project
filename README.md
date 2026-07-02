# CRM Screening Tasks - ASP.NET Core MVC

This project is an ASP.NET Core MVC application built for the CRM Developer screening tasks. It uses in-memory customer data only, so no database setup is required.

## Tech Stack

- ASP.NET Core MVC
- C#
- .NET 6
- Razor Views
- Bootstrap 5
- SignalR
- In-memory data

## Project Structure

```text
CrmScreeningTasks/
  Controllers/
    HomeController.cs
    CustomersController.cs
    NotificationsController.cs
  Data/
    CustomerSeedData.cs
  Hubs/
    NotificationsHub.cs
  Models/
    Customer.cs
    ErrorViewModel.cs
  ViewModels/
    HomeIndexViewModel.cs
  Views/
    Home/
    Customers/
    Notifications/
    Shared/
  wwwroot/
    css/
    js/
    lib/
```

## Completed Tasks

### Task 1 - C# Model

The `Customer` model is located in:

```text
Models/Customer.cs
```

It includes:

- `Id`
- `FullName`
- `Email`
- `Phone`
- `CreatedAt`
- `IsActive`, defaulted to `true`
- `GetSummary()` method

The home page displays two hardcoded customer summary strings using `GetSummary()`.

### Task 2 - LINQ

The home page uses a list of hardcoded customers from:

```text
Data/CustomerSeedData.cs
```

The LINQ results are prepared in:

```text
Controllers/HomeController.cs
```

Displayed results:

- Active customers sorted alphabetically by full name
- First customer with a Gmail address
- Count of customers created in the current year

### Task 3 - Customers List Page

The customers list is handled by:

```text
Controllers/CustomersController.cs
Views/Customers/Index.cshtml
```

It displays customers in a Bootstrap 5 table with:

- Name
- Email
- Phone
- Status

The navigation menu includes a link to the Customers page.

### Task 4 - Create Form With Validation

The create page is handled by:

```text
Controllers/CustomersController.cs
Views/Customers/Create.cshtml
```

The form includes:

- Full Name
- Email
- Phone

Validation:

- Full Name is required.
- If Full Name is empty, an inline validation message is shown.
- If valid, the user is redirected back to the customers list.

### Task 5 - Real-Time Notifications With SignalR

SignalR is configured in:

```text
Program.cs
Hubs/NotificationsHub.cs
Views/Notifications/Index.cshtml
wwwroot/js/notifications.js
```

The Notifications page lets users type a message and send it in real time. The message appears immediately in all open browser tabs without refreshing the page.

## How To Run

Open the solution in Visual Studio 2022:

```text
CrmScreeningTasks.sln
```

Or run from the terminal:

```powershell
dotnet restore
dotnet run
```

Then open the local URL shown in the terminal.

## Main Pages

```text
/               Home dashboard
/Customers      Customers list
/Customers/Create
/Notifications  SignalR real-time notifications
```

## Verification Steps

1. Open the Home page and confirm:
   - Two customer summaries are visible.
   - Active customers are sorted by name.
   - First Gmail customer is displayed.
   - Current-year customer count is displayed.

2. Open `/Customers` and confirm:
   - Bootstrap table is visible.
   - Name, Email, Phone, and Status columns are shown.
   - Create Customer button is available.

3. Open `/Customers/Create` and submit with an empty Full Name:
   - Inline validation message should appear.

4. Submit the Create form with a valid Full Name:
   - The app redirects to the Customers list.

5. Open `/Notifications` in two browser tabs:
   - Send a message from one tab.
   - Confirm it appears instantly in the other tab.

## Notes

- No database is used.
- Customer data is hardcoded in memory.
- Created customers are validated and redirected according to the screening requirements.
- SignalR is used for real-time browser-to-browser notifications.
