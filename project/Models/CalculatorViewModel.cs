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

        public string pageTitle { get; set; }
    }
}
