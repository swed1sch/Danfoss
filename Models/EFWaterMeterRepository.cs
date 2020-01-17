using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Danfoss.Models
{
    public class EFWaterMeterRepository:IWaterMeterRepository
    {
        private ApplicationDbContext context;
        
        public EFWaterMeterRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<WaterMeter> waterMeters => context.waterMeters;
    }
}
