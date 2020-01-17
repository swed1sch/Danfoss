using System.Linq;
using System.Collections.Generic;

namespace Danfoss.Models
{
    public class EFHouseRepository : IHouseRepository
    {
        private ApplicationDbContext context;
        public EFHouseRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<House> Houses => context.Houses;
        
        
    }
    
}
