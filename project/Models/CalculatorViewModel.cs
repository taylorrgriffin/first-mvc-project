using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using project.Models;

namespace project.Models
{
    public class CalculatorViewModel : PageModel
    {
        public void OnGet()
        {
            //Calculation = new Calculation();
        }

        public CalculatorViewModel()
        {
            Calculation = new Calculation();
        }

        public string PageTitle { get; set; }

        public Calculation Calculation { get; set; }

    }
}
