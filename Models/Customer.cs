using System.ComponentModel.DataAnnotations;

namespace CrmScreeningTasks.Models;

public class Customer
{
    public int Id { get; set; }

    public string FullName { get; set; } = string.Empty;

    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string Email { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public bool IsActive { get; set; } = true;

    public string GetSummary()
    {
        var status = IsActive ? "Active" : "Inactive";

        return $"#{Id} - {FullName} | Email: {Email} | Phone: {Phone} | Created: {CreatedAt:MMM dd, yyyy} | Status: {status}";
    }
}
