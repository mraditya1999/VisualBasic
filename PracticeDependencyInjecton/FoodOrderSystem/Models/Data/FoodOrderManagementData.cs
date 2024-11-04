using FoodOrderSystem.DataAccessLayer;
using FoodOrderSystem.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodOrderSystem.Models.Data
{
    public class FoodOrderManagementData : IFoodOrder
    {
        public void AddFoodOrder(FoodOrder order)
        {
            FoodOrderDal dal = new FoodOrderDal();
            dal.AddFoodOrder(order);
        }

        public void DeleteFoodOrder(int foodOrderId)
        {
            FoodOrderDal dal = new FoodOrderDal();
            dal.DeleteFoodOrder(foodOrderId);
        }

        public IEnumerable<FoodOrder> GetAllFoodOrderDetails()
        {
            FoodOrderDal dal = new FoodOrderDal();
            List<FoodOrder> list = (from ord in dal.GetAllFoodOrderDetails() select ord).ToList();
            //var studentsList = (from stu in dal.GetAllStudentDetails() select stu).ToList();
            return list;

        }

        public void UpdateFoodOrder(FoodOrder order)
        {
            FoodOrderDal dal = new FoodOrderDal();
            dal.UpdateFoodOrder(order);
        }

    }
}