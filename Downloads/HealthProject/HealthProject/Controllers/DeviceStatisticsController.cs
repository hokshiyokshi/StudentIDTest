using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HealthProject.Data;
using HealthProject.Models;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace HealthProject.Controllers
{
    public class DeviceStatisticsController : Controller
    {
        private readonly HealthDbContext _context;
        private readonly ILogger<DeviceStatisticsController> _logger;

        public DeviceStatisticsController(HealthDbContext context, ILogger<DeviceStatisticsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: DeviceStatistics
        public async Task<IActionResult> Index()
        {
            return View(await _context.DeviceStatistics.ToListAsync());
        }

        // GET: DeviceStatistics/Create
        public IActionResult Create()
        {
            return View("CreateDeviceStatistic");
        }

        // POST: DeviceStatistics/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DeviceStatistic deviceStatistic)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(deviceStatistic);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Device Statistic created successfully."; // Store the successDe message
                    return RedirectToAction(nameof(Create)); // Redirect back to the Create view
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "An error occurred while creating the device statistic.");
                    ModelState.AddModelError("", "An error occurred while creating the device statistic."); // Add a model error to be displayed in the view
                }
            }
            return View("~/Views/DeviceStatistics/CreateDeviceStatistic.cshtml");
             // Return to the CreateDeviceStatistic view with the model to show validation messages or errors
        }

        // Additional actions can be added here as needed
    }
}