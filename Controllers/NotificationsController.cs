using Microsoft.AspNetCore.Mvc;

namespace CrmScreeningTasks.Controllers;

public class NotificationsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
