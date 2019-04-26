using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace project.Models
{

    public class Calculation
    {
        public Calculation()
        {
            InputEquation = new Equation();
            OutputEquation = new Equation();
        }

        [Required]
        public Equation InputEquation { get; set; }

        public Equation OutputEquation { get; set; }

        //public IEnumerable<Operation> Operations { get; set; }

        // TODO: Add InputPlot and OutPutPlot classes & attributes
    }
}
