using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitFormula.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int CalorieGoal { get; set; }
        public string Email { get; set; }
    }
}