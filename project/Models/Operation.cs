using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace project.Models
{

    public class Operation
    {
        [DisplayPrefix("y = ")]
        [DropdownLabel("Simplify expression")]
        [ApiKeyWord("simplify")]
        public virtual Boolean IsSimplify { get; set; } = false;

        [DisplayPrefix("f(x) = ")]
        [DropdownLabel("Take derivative")]
        [ApiKeyWord("derive")]
        public virtual Boolean IsDerivative { get; set; } = false;

        [DisplayPrefix("g(x) = ")]
        [DropdownLabel("Calculate tangent")]
        [ApiKeyWord("tan")]
        public virtual Boolean IsTangent { get; set; } = false;

        //TODO: Add rest of operations supported by API
    }

    public class ApiKeyWord : Attribute
    {
        public ApiKeyWord(String keyword)
        {
            this.KeyWord = keyword;
        }
        public String KeyWord { get; set; }
    }

    public class DropdownLabel : Attribute
    {
        public DropdownLabel(String label)
        {
            this.Label = label;
        }
        public String Label { get; set; }
    }

    public class DisplayPrefix : Attribute
    {
        public DisplayPrefix(String prefix)
        {
            this.Prefix = prefix;
        }
        public string Prefix { get; set; }
    }

    //TODO: Create a shared interface that inherits from Attribute for above classes
}


