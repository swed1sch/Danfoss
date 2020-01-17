using Microsoft.AspNetCore.Mvc;
using Danfoss.Models;

namespace Danfoss.Controllers
{
    public class HouseController:Controller
    {
        private IHouseRepository repository;
        private IWaterMeterRepository repositoryw;
        public HouseController(IHouseRepository repo,IWaterMeterRepository repow)
        {
            repository = repo;
            repositoryw = repow;
            
        }
        public ViewResult List() => View(repository.Houses);
        //public ViewResult WaterMeterList() => View(repositoryw.waterMeters);
       
        
    }
}
