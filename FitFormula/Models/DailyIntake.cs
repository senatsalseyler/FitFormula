using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitFormula.Models
{
    public class DailyIntake
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public DateTime Date { get; set; }
        public List<FoodEntry> Foods { get; set; } = new List<FoodEntry>();
        public double TotalCalories => Foods.Sum(f => f.Calories);
    }

    public class FoodEntry
    {
        public string FoodId { get; set; }
        public string FoodName { get; set; }
        public double Calories { get; set; }
        public DateTime AddedAt { get; set; }
    }
}