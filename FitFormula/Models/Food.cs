using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitFormula.Models
{
    public class Food
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbs { get; set; }
        public string ImageUrl { get; set; }
    }
}