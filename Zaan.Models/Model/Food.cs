using System;
using System.Collections.Generic;
using System.Text;

namespace Zaan.Models.Model
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public FoodCategory FoodCategory { get; set; }
    }
}
