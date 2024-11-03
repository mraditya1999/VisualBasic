using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodOrderSystem
{
    public class FoodOrderManagement
    {
        public List<FoodOrder> GetAllFoodOrderDetails()
        {
            using (var entities = new FoodOrderSystemEntities())
            {
                return entities.FoodOrders.ToList();
            }
        }

        public void AddFoodOrder(FoodOrder food)
        {
            using (var entities = new FoodOrderSystemEntities())
            {
                entities.FoodOrders.Add(food);
                entities.SaveChanges();
            }
        }

        public void UpdateFoodOrder(FoodOrder updatedFoodOrder)
        {
            using (var entities = new FoodOrderSystemEntities())
            {
                var existingFoodOrder = entities.FoodOrders.FirstOrDefault(x => x.foodOrderId == updatedFoodOrder.foodOrderId);
                if (existingFoodOrder != null)
                {
                    existingFoodOrder.foodOrderName = updatedFoodOrder.foodOrderName;
                    existingFoodOrder.foodOrderPrice = updatedFoodOrder.foodOrderPrice;
                    existingFoodOrder.foodOrderQuantity = updatedFoodOrder.foodOrderQuantity;
                    entities.SaveChanges();
                }
            }
        }

        public void DeleteFoodOrder(int foodOrderId)
        {
            using (var entities = new FoodOrderSystemEntities())
            {
                var result = entities.FoodOrders.FirstOrDefault(x => x.foodOrderId == foodOrderId);
                if (result != null)
                {
                    entities.FoodOrders.Remove(result);
                    entities.SaveChanges();
                }
            }
        }
    }
}