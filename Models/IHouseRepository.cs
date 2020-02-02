using System.Linq;
using System.Collections.Generic;

namespace Danfoss.Models
{
    public interface IHouseRepository
    {

        IQueryable<House> Houses { get; }
        IQueryable<House> HouseFilter { get; }
        void AddHouse(House house);
       
    }
}
