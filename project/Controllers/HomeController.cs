﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            CalculatorViewModel calculatorViewModel = new CalculatorViewModel();
            calculatorViewModel.pageTitle = "Calculator";
            return View(calculatorViewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ContactViewModel viewModel = new ContactViewModel();
            viewModel.contactName = "Alex De Paz";
            //ViewData["Message"] = "Your contact page.";

            return View(viewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
