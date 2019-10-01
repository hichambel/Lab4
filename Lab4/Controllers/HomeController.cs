using Lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Order oneOrder, FormCollection form)
        {
            double[] subPrices = new double[] { 5, 6, 7, 8, 9  };
            double[] sizePrices = new double[] { 2.50, 3.50, 4.50, 5.50 };
            double[] dealPrices = new double[] { 0, 2.75, 3.75 };

            string subType = Enum.GetName(typeof(SubType), oneOrder.Sub);
            var priceSub = subPrices[(int)oneOrder.Sub];

            string subSize = Enum.GetName(typeof(SubSize), oneOrder.Size);
            var priceSize = sizePrices[(int)oneOrder.Size];

            string dealName = Enum.GetName(typeof(MealDeal), oneOrder.mealDeal);
            var priceDeal = dealPrices[(int)oneOrder.mealDeal];

            double totalSubNoDeal = priceSub + priceSize;

            double totalSubDeal = totalSubNoDeal + priceDeal;

            double taxAmount = totalSubDeal * .15;
            double grandTotal = totalSubDeal + taxAmount;

            ViewBag.Sub = subType;
            ViewBag.Bread = subSize;
            ViewBag.PriceSub = totalSubNoDeal;
            ViewBag.DealName = dealName;
            ViewBag.PriceDeal = priceDeal;
            ViewBag.BeforeTaxCost = totalSubDeal;
            ViewBag.Tax = taxAmount;
            ViewBag.Total = grandTotal;

            return View("Receipt");
        }
    }
}