using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestMSTeam1.Models;
//using Serilog;
using Microsoft.Extensions.Logging;

namespace TestMSTeam1.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger logger;

		public HomeController(ILogger<HomeController> logger)
		{
			this.logger = logger;
		}

		public IActionResult Index()
		{
			// Testing
			logger.LogInformation("Information Test");
			logger.LogWarning("Warning Test");
			logger.LogCritical("Critical Test");
			logger.LogError("Error Test");
			logger.LogDebug("Debug Test");
			// Testing

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
