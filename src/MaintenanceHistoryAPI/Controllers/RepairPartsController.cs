using Microsoft.AspNetCore.Mvc;

namespace Pitstop.MaintenanceHistoryAPI.Controllers;

public class RepairPartsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}