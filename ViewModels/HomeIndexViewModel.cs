using CrmScreeningTasks.Models;

namespace CrmScreeningTasks.ViewModels;

public class HomeIndexViewModel
{
    public int TotalCustomers { get; set; }

    public int ActiveCustomerCount { get; set; }

    public int InactiveCustomerCount { get; set; }

    public List<Customer> SummaryCustomers { get; set; } = new();

    public List<Customer> ActiveCustomersSortedByName { get; set; } = new();

    public Customer? FirstGmailCustomer { get; set; }

    public int CurrentYearCustomerCount { get; set; }

    public int CurrentYear { get; set; }
}
