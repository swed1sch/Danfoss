using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Danfoss.Models
{
    public class EFHouseRepository : IHouseRepository
    {
        private ApplicationDbContext context;
        public EFHouseRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<House> Houses => context.Houses.Include(c => c.waterMeter);
        public void AddHouse(House house)
        {
            this.context.Houses.Add(house);
            this.context.SaveChanges();
        }
        
        
    }
    
}
