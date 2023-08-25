﻿using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Table()
        {
            var items = new List<Item>();
            var item1 = new Item();
            item1.ItemId = 1;
            item1.Name = "Pizza";
            item1.Price = 60;

            var item2 = new Item()
            {
                ItemId = 2,
                Name = "Fried Chicken Leg",
                Price = 15
            };

            var item3 = new Item()
            {
                ItemId = 3,
                Name = "Tacos",
                Price = 50
            };

            items.Add(item1);
            items.Add(item2);
            items.Add(item3);

            ViewBag.CurrentViewName = "List of Shop Items";
            return View(items);
        }
    }
}
