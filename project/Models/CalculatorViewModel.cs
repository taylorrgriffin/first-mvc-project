using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace project.Models
{
    public class CalculatorViewModel : PageModel
    {
        public void OnGet()
        {

        }

        public string PageTitle { get; set; }

        public string InputEquation { get; set; }

        public string Derivative { get; set; }
    }
}
