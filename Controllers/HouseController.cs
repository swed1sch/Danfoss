using Microsoft.AspNetCore.Mvc;
using Danfoss.Models;

namespace Danfoss.Controllers
{
    public class HouseController:Controller
    {
        private IHouseRepository repository;

        
        public HouseController(IHouseRepository repo)
        {
            repository = repo;
            
            
        }
        public ViewResult List() => View(repository.Houses);
        public IActionResult Create() => View();
        [HttpPost]
        public IActionResult Create(House house)
        {
            repository.AddHouse(house);            
            return RedirectToAction(nameof(List));
        }
        public IActionResult Thanks(House house) => View(house);
        
    }
}
