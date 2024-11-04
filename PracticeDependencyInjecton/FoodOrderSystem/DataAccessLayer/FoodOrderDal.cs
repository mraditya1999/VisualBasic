using FoodOrderSystem.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FoodOrderSystem.DataAccessLayer
{
    public class FoodOrderDal
    {
        public IEnumerable<FoodOrder> GetAllFoodOrderDetails()
        {
            Connection obj = new Connection();
            List<FoodOrder> foodOrdersList = new List<FoodOrder>();
            obj.con.Open();
            obj.cmd.CommandText = "SELECT * FROM FoodOrder";
            SqlDataReader reader = obj.cmd.ExecuteReader();
            while (reader.Read())
            {
                foodOrdersList.Add(new FoodOrder { FoodOrderId = reader.GetInt32(0), FoodOrderName = reader.GetString(1), FoodOrderQuantity = reader.GetInt32(2) });
            }

            reader.Close();
            obj.con.Close();
            return foodOrdersList;
        }
        public void AddFoodOrder(FoodOrder foodOrder)
        {
            Connection obj = new Connection();
            obj.con.Open();
            obj.cmd.CommandText = $"INSERT INTO FoodOrder(foodOrderId,foodOrderName,foodOrderQuantity,foodOrderPrice) VALUES ('{foodOrder.FoodOrderId}','{foodOrder.FoodOrderName}','{foodOrder.FoodOrderQuantity}','{foodOrder.FoodOrderPrice}')";
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
        }
        public void UpdateFoodOrder(FoodOrder foodOrder)
        {
            Connection obj = new Connection();
            obj.con.Open();
            obj.cmd.CommandText = $"UPDATE FoodOrder SET foodOrderName='{foodOrder.FoodOrderName}', foodOrderQuantity='{foodOrder.FoodOrderQuantity}', foodOrderPrice='{foodOrder.FoodOrderPrice}' WHERE foodOrderId='{foodOrder.FoodOrderId}'";
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
        }
        public void DeleteFoodOrder(int foodOrderId)
        {
            Connection obj = new Connection();
            obj.con.Open();
            obj.cmd.CommandText = $"DELETE FROM FoodOrder WHERE foodOrderId = '{foodOrderId}'";
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
        }
    }
}