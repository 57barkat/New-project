using CrmScreeningTasks.Models;

namespace CrmScreeningTasks.Data;

public static class CustomerSeedData
{
    public static List<Customer> GetCustomers()
    {
        var currentYear = DateTime.Now.Year;

        return new List<Customer>
        {
            new()
            {
                Id = 1,
                FullName = "Ayesha Khan",
                Email = "ayesha.khan@gmail.com",
                Phone = "+92 300 1111111",
                CreatedAt = new DateTime(currentYear, 1, 15),
                IsActive = true
            },
            new()
            {
                Id = 2,
                FullName = "Bilal Ahmed",
                Email = "bilal.ahmed@outlook.com",
                Phone = "+92 300 2222222",
                CreatedAt = new DateTime(currentYear - 1, 8, 20),
                IsActive = false
            },
            new()
            {
                Id = 3,
                FullName = "Fatima Noor",
                Email = "fatima.noor@example.com",
                Phone = "+92 300 3333333",
                CreatedAt = new DateTime(currentYear, 3, 10),
                IsActive = true
            },
            new()
            {
                Id = 4,
                FullName = "Omar Siddiqui",
                Email = "omar.siddiqui@gmail.com",
                Phone = "+92 300 4444444",
                CreatedAt = new DateTime(currentYear - 2, 11, 5),
                IsActive = false
            },
            new()
            {
                Id = 5,
                FullName = "Zara Malik",
                Email = "zara.malik@company.com",
                Phone = "+92 300 5555555",
                CreatedAt = new DateTime(currentYear, 6, 1),
                IsActive = true
            }
        };
    }
}
