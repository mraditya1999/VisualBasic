using FoodOrderSystem.Models.Abstract;
using FoodOrderSystem.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFoodOrder _foodOrder;
        public HomeController(FoodOrderManagementData food)
        {
            _foodOrder = food;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var foodOrders = _foodOrder.GetAllFoodOrderDetails();
            return View(foodOrders);
        }


        [HttpGet]
        public ActionResult AddFoodOrder()
        {
            return View(new FoodOrder());
        }


        [HttpPost]
        public ActionResult AddFoodOrder(FoodOrder foodOrder)
        {
            if (ModelState.IsValid)
            {
                _foodOrder.AddFoodOrder(foodOrder);
                return RedirectToAction("Index");
            }
            return View(foodOrder);
        }

        [HttpGet]
        public ActionResult UpdateFoodOrder(int foodOrderId)
        {
            var result = _foodOrder.GetAllFoodOrderDetails().FirstOrDefault(x => x.FoodOrderId == foodOrderId);
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        [HttpPost]
        public ActionResult UpdateFoodOrder(FoodOrder foodOrder)
        {
            if (ModelState.IsValid)
            {
                _foodOrder.UpdateFoodOrder(foodOrder);
                return RedirectToAction("Index");
            }
            return View(foodOrder);
        }

        [HttpGet]
        public ActionResult DeleteFoodOrder(int foodOrderId)
        {
            _foodOrder.DeleteFoodOrder(foodOrderId);
            return RedirectToAction("Index");
        }


    }
}