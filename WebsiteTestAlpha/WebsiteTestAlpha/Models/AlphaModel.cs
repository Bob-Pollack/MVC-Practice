using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebsiteTestAlpha.Models
{
    public class AlphaModel
    {
        public int CountUp { get; set; }

        [Range(-100, 100, ErrorMessage = "absolute value of range must be 100 or less")]
        public double UserInput { get;  set;}

        public string ExtraMessage { get; set; }
        

        

    }
}