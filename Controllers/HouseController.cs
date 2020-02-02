using Microsoft.AspNetCore.Mvc;
using Danfoss.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Danfoss.Controllers
{
    public class HouseController:Controller
    {
        private IHouseRepository repository;

        
        public HouseController(IHouseRepository repo)
        {
            repository = repo;
                        
        }
        public ViewResult Filter() => View(repository.HouseFilter);

        public ViewResult List() => View(repository.Houses);
        public IActionResult Create() => View();
        [HttpPost]
        public IActionResult Create(House house)
        {
            if (house.waterMeter.FactoryNumber < 0 || house.waterMeter.Indication < 0)
                throw new ArgumentException("Value can be plus!");
            else if (house.Address == null)
                throw new ArgumentException("Address can't be null!");
            else
            {
                repository.AddHouse(house);
                return RedirectToAction(nameof(List));
            }
            
            
        }
        public IActionResult Thanks(House house) => View(house);
        
    }
}
