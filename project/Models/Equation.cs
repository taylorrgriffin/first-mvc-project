using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace project.Models
{

    public class Equation
    {
        public string prefix { get; set; }

        public string contents { get; set; }

        public Boolean isValid { get; private set; } 

        //TODO: Add regex to validate equation

    }

}
