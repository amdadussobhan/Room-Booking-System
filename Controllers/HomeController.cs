using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Room_Booking_System.Data;
using Room_Booking_System.Models;

namespace Room_Booking_System.Controllers;

public class HomeController : Controller
{
    AppDbContext _db;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _db = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.bookings = _db.Bookings;
        return View();
    }
}
