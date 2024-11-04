using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderSystem.Models.Abstract
{
    public interface IFoodOrder
    {
        IEnumerable<FoodOrder> GetAllFoodOrderDetails();
        void AddFoodOrder(FoodOrder order);
        void UpdateFoodOrder(FoodOrder order);
        void DeleteFoodOrder(int foodOrderId);
    }
}
