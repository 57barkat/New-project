using System.Diagnostics;
using CrmScreeningTasks.Data;
using CrmScreeningTasks.Models;
using CrmScreeningTasks.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CrmScreeningTasks.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var customers = CustomerSeedData.GetCustomers();
        var currentYear = DateTime.Now.Year;

        var viewModel = new HomeIndexViewModel
        {
            TotalCustomers = customers.Count,
            ActiveCustomerCount = customers.Count(customer => customer.IsActive),
            InactiveCustomerCount = customers.Count(customer => !customer.IsActive),
            SummaryCustomers = customers.Take(2).ToList(),
            ActiveCustomersSortedByName = customers
                .Where(customer => customer.IsActive)
                .OrderBy(customer => customer.FullName)
                .ToList(),
            FirstGmailCustomer = customers
                .FirstOrDefault(customer => customer.Email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase)),
            CurrentYearCustomerCount = customers.Count(customer => customer.CreatedAt.Year == currentYear),
            CurrentYear = currentYear
        };

        return View(viewModel);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
