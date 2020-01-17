using System;
using System.Collections.Generic;
using System.Linq;


namespace Danfoss.Models
{
    public class FakeRepository : IHouseRepository
    {
        Random random = new Random();
        public IQueryable<House> Houses => new List<House> {
        new House{
            Address="SomeAddress11",
            waterMeter=new WaterMeter
            {
                FactoryNumber=random.Next(100,200),
                Indication=random.Next(100,200)
            }
            },
        new House{
            Address="SomeAddress22",
            waterMeter=new WaterMeter
            {
                FactoryNumber=random.Next(100,200),
                Indication=random.Next(100,200)
            }
            },
        new House{
            Address="SomeAddress33",
            waterMeter=new WaterMeter
            {
                FactoryNumber=random.Next(100,200),
                Indication=random.Next(100,200)
            }
            }}.AsQueryable<House>();
        
    }
}
