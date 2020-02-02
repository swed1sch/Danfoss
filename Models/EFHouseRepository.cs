using System.Linq;
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
        
        public IQueryable<House> HouseFilter => context.Houses.OrderBy(b=>context.Houses.Include(c=>c.waterMeter.Indication)); 
        public void AddHouse(House house)
        {
            this.context.Houses.Add(house);
            this.context.SaveChanges();
        }
        
        
    }
    
}
