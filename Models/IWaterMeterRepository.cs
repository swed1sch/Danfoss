using System;
using System.Collections.Generic;
using System.Linq;


namespace Danfoss.Models
{
    public interface IWaterMeterRepository
    {
        IQueryable<WaterMeter> waterMeters { get; }
    }
}
