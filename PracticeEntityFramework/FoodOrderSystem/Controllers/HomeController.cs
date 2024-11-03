using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodOrderSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly FoodOrderManagement _context = new FoodOrderManagement();

        [HttpGet]
        public ActionResult Index()
        {
            var foodOrders = _context.GetAllFoodOrderDetails();
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
                _context.AddFoodOrder(foodOrder);
                return RedirectToAction("Index");
            }
            return View(foodOrder);
        }


        [HttpGet]
        public ActionResult UpdateFoodOrder(int foodOrderId)
        {
            var foodOrder = _context.GetAllFoodOrderDetails().FirstOrDefault(x => x.foodOrderId == foodOrderId);
            if (foodOrder == null)
            {
                return HttpNotFound();
            }
            return View(foodOrder);
        }

        [HttpPost]
        public ActionResult UpdateFoodOrder(FoodOrder foodOrder)
        {
            if (ModelState.IsValid)
            {
                _context.UpdateFoodOrder(foodOrder);
                return RedirectToAction("Index");
            }
            return View(foodOrder);
        }

        [HttpGet]
        public ActionResult DeleteFoodOrder(int foodOrderId)
        {
            _context.DeleteFoodOrder(foodOrderId);
            return RedirectToAction("Index");
        }
    }
}