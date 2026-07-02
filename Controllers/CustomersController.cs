using CrmScreeningTasks.Data;
using CrmScreeningTasks.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrmScreeningTasks.Controllers;

public class CustomersController : Controller
{
    public IActionResult Index()
    {
        return View(CustomerSeedData.GetCustomers().Take(4).ToList());
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View(new Customer());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Customer customer)
    {
        if (string.IsNullOrWhiteSpace(customer.FullName))
        {
            ModelState.AddModelError(nameof(Customer.FullName), "Full Name is required.");
        }

        if (!ModelState.IsValid)
        {
            return View(customer);
        }

        return RedirectToAction(nameof(Index));
    }

}
