using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodOrderSystem.Models.Abstract
{
    public class FoodOrder
    {

        public int FoodOrderId { get; set; }
        public string FoodOrderName { get; set; }
        public int FoodOrderQuantity { get; set; }
        public float FoodOrderPrice { get; set; }
    }
}