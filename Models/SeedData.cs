using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Danfoss.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {

            ApplicationDbContext context = app.ApplicationServices.
                GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            
                
            
            if (!context.Houses.Any())
            {
                context.Houses.AddRange(
                    new House
                    {

                        Address = "SomeAddressFromHouse11",
                        waterMeter = new WaterMeter
                        {
                            FactoryNumber=1001,
                            Indication=10001
                        }
                    },

                    new House
                    {

                        Address = "SomeAddressFromHouse22",
                        waterMeter = new WaterMeter
                        {
                            FactoryNumber=1002,
                            Indication=10002
                        }
                    },
                    new House
                    {

                        Address = "SomeAddressFromHouse3",
                        waterMeter = new WaterMeter
                        {
                            FactoryNumber=1003,
                            Indication=10003
                        }
                    },
                    new House
                    {

                        Address = "SomeAddressFromHouse4",
                        waterMeter = new WaterMeter
                        {
                            FactoryNumber=1004,
                            Indication=10004
                        }
                    },
                    new House
                    {

                        Address = "SomeAddressFromHouse5",
                        waterMeter = new WaterMeter
                        {
                            FactoryNumber=1005,
                            Indication=10005
                        }
                    },
                   new House
                   {

                       Address = "SomeAddressFromHouse6",
                       waterMeter = new WaterMeter
                       {
                           FactoryNumber=1006,
                           Indication=10006
                       }
                   }
                    );

                context.SaveChanges();
            }

        }
        private static Dictionary<int, WaterMeter> watersMeter;
        public static Dictionary<int, WaterMeter> waterMeters
        {
            get
            {
                if (watersMeter == null)
                {
                    var list = new WaterMeter[]
                    {
                        new WaterMeter
                        {
                            FactoryNumber = 10001,
                            Indication = 100001
                        },
                        new WaterMeter
                        {
                            FactoryNumber = 10002,
                            Indication = 100002
                        },
                        new WaterMeter
                        {
                            FactoryNumber = 10003,
                            Indication = 100003
                        }
                    };
                    watersMeter = new Dictionary<int, WaterMeter>();
                    foreach (WaterMeter v in list)
                        watersMeter.Add(v.FactoryNumber, v);
                }
                return watersMeter;
            }
        }
    }
}
