﻿using System.Diagnostics;
using System.Security.Policy;
using GebruikerProfiel.Models;
using Microsoft.AspNetCore.Mvc;

namespace GebruikerProfiel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		private const string PageViews = "PageViews";
        public HomeController(ILogger<HomeController> logger)
        {
			_logger = logger;
        }

        public IActionResult Index()
        {
            UpdatePageViewCookie();
            return View();
        }

        public IActionResult Privacy()
        {
			UpdatePageViewCookie();
			return View();
        }

        public IActionResult Contact()
        {
            UpdatePageViewCookie();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
		public void UpdatePageViewCookie()
		{
			var currentCookieValue = Request.Cookies[PageViews];

			if (currentCookieValue == null)
			{
				Response.Cookies.Append(PageViews, "1");
			}
			else
			{
				var newCookieValue = short.Parse(currentCookieValue) + 1;

				Response.Cookies.Append(PageViews, newCookieValue.ToString());
                
			}
		}
	}
}