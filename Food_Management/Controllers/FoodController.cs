﻿using Food_Management.Data.Models;
using Food_Management.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Food_Management.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            FoodRepository foodRepository = new FoodRepository();
            return View(foodRepository.TList("Category"));      //give a parameter to reach this data type
        }
        [HttpGet]
        public IActionResult AddFood()
        {
           return View();
        }
        [HttpPost]  
        public IActionResult AddFood(Food p)
        {
            return View();
        }
    }
}
