﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Entities
{
    public static class DatabaseContextExtension
    {
        public static void SeedData(this IApplicationBuilder builder)
        {
            var provider = builder.ApplicationServices;
            var scopeFactory = provider.GetRequiredService<IServiceScopeFactory>();

            using (var scope = scopeFactory.CreateScope())
            using (var context = scope.ServiceProvider.GetRequiredService<DatabaseContext>())
            {
                if (context.Commodities.Count() == 0)
                {
                var commodities = new List<Commodity>()
                {
                    new Commodity
                    {
                        Id = Guid.NewGuid(),
                        name = "Foods & Beverages"
                    },
                     new Commodity
                     {
                         Id = Guid.NewGuid(),
                         name = "Paper & Chemical Products"
                     },
                     new Commodity
                     {
                        Id = Guid.NewGuid(),
                        name = "Electtronics & Electrical material"
                    },
                    new Commodity
                    {
                        Id = Guid.NewGuid(),
                        name = "Machinery, Utensils & Metalware"
                    },
                    new Commodity
                    {
                        Id = Guid.NewGuid(),
                        name = "Marble & Tiles"
                    },
                    new Commodity
                    {
                        Id = Guid.NewGuid(),
                        name = "Funiture, Frames, Wood Articles"
                    },
                    new Commodity
                    {
                        Id = Guid.NewGuid(),
                        name = "Textiles, Gaments and accessories"
                    },
                     new Commodity
                    {
                        Id = Guid.NewGuid(),
                        name = "Glass, Ceramic and Plasticware"
                    },
                     new Commodity
                    {
                        Id = Guid.NewGuid(),
                        name = "Seafood"
                    },
                     new Commodity
                    {
                        Id = Guid.NewGuid(),
                        name = "Rice"
                    },
                    new Commodity
                    {
                        Id = Guid.NewGuid(),
                        name = "Coffee"
                    },
                    new Commodity
                    {
                        Id = Guid.NewGuid(),
                        name = "Others"
                    },
                };

                context.Commodities.AddRange(commodities);
            }

            if (context.TypeOfBills.Count() == 0)
            {
                var typeOfBill = new List<TypeOfBill>
                {
                    new TypeOfBill
                    {
                        Id = Guid.NewGuid(),
                        name = "COPY"
                    },
                    new TypeOfBill
                    {
                        Id = Guid.NewGuid(),
                        name = "ORIGINAL"
                    },
                    new TypeOfBill
                    {
                        Id = Guid.NewGuid(),
                        name = "SURRENDERED"
                    }
                };
                context.TypeOfBills.AddRange(typeOfBill);
            }

            if (context.Shipments.Count() == 0)
            {
                var shipments = new List<Shipment>
                {
                    new Shipment
                    {
                        Id  = Guid.NewGuid(),
                        name = "FREE-HAND"
                    },
                    new Shipment
                    {
                        Id = Guid.NewGuid(),
                        name = "NOMINATED"
                    }
                };
                context.Shipments.AddRange(shipments);
            }

            if (context.Nationalities.Count() == 0)
            {
                var nationalities = new List<Nationality>
                {
                    new Nationality
                    {
                        Id = Guid.NewGuid(),
                        name = "AFGHANISTAN"
                    },
                     new Nationality
                    {
                        Id = Guid.NewGuid(),
                        name = "ALBANIA"
                    },
                      new Nationality
                    {
                        Id = Guid.NewGuid(),
                        name = "AMERICAN SAMOA"
                    },
                       new Nationality
                    {
                        Id = Guid.NewGuid(),
                        name = "ANDORRA"
                    }
                };
                context.Nationalities.AddRange(nationalities);
            }

            if (context.Zones.Count() == 0)
            {
                var zones = new List<Zone>
                {
                    new Zone
                    {
                        Id = Guid.NewGuid(),
                        name = "AFRICA"
                    },
                    new Zone
                    {
                        Id = Guid.NewGuid(),
                        name = "ASIA"
                    },
                    new Zone
                    {
                        Id = Guid.NewGuid(),
                        name = "Central America"
                    },
                    new Zone
                    {
                        Id = Guid.NewGuid(),
                        name = "EUROPE"
                    },
                    new Zone
                    {
                        Id = Guid.NewGuid(),
                        name = "MIDDLE EAST"
                    },
                    new Zone
                    {
                        Id = Guid.NewGuid(),
                        name = "North America"
                    },
                    new Zone
                    {
                        Id = Guid.NewGuid(),
                        name = "North Asia"
                    },
                    new Zone
                    {
                        Id = Guid.NewGuid(),
                        name = "Oceania"
                    },
                    new Zone
                    {
                        Id = Guid.NewGuid(),
                        name = "South America"
                    },
                    new Zone
                    {
                        Id = Guid.NewGuid(),
                        name = "South Asia"
                    },
                    new Zone
                    {
                        Id = Guid.NewGuid(),
                        name = "OTHERS"
                    }
                };
                context.Zones.AddRange(zones);
            }

            if (context.Modes.Count() == 0)
            {
                var modes = new List<Mode>
                {
                    new Mode
                    {
                        Id = Guid.NewGuid(),
                        name = "AIR"
                    },
                     new Mode
                    {
                        Id = Guid.NewGuid(),
                        name = "SEA"
                    },
                     new Mode
                    {
                        Id = Guid.NewGuid(),
                        name = "SEA&AIR"
                    },
                     new Mode
                    {
                         Id = Guid.NewGuid(),
                        name = "SEA&AIR&INLAND"
                    },
                     new Mode
                    {
                        Id = Guid.NewGuid(),
                        name = "AIR&INLAND"
                    },
                     new Mode
                    {
                           Id = Guid.NewGuid(),
                        name = "DEPOT"
                    },
                     new Mode
                    {
                        Id = Guid.NewGuid(),
                        name = "SEA&DEPOT"
                    },
                     new Mode
                    {
                        Id = Guid.NewGuid(),
                        name = "INLAND&DEPOT"
                    },
                    new Mode
                    {
                          Id = Guid.NewGuid(),
                        name = "SEA&AIR&INLAND&DEPOT"
                    },
                    new Mode
                    {
                          Id = Guid.NewGuid(),
                        name = "EXPRESS"
                    }
                };
                context.Modes.AddRange(modes);
            }

            if (context.Units.Count() == 0)
            {
                var units = new List<Unit>
                {
                    new Unit
                    {
                        Id = Guid.NewGuid(),
                        name = "BAG"
                    },
                     new Unit
                    {
                        Id = Guid.NewGuid(),
                        name = "BL"
                    },
                     new Unit
                    {
                        Id = Guid.NewGuid(),
                        name = "BOXES"
                    },
                     new Unit
                    {
                        Id = Guid.NewGuid(),
                        name = "CBM"
                    }
                };
                context.Units.AddRange(units);
            }
            if (context.Payments.Count() == 0)
            {
                var payments = new List<Payment>
                {
                    new Payment
                    {
                        Id = Guid.NewGuid(),
                        name = "FREIGHT PREPAID"
                    },
                    new Payment
                    {
                        Id = Guid.NewGuid(),
                        name = "FREIGHT COLLECT"
                    }
                };
                context.Payments.AddRange(payments);
            }
            if (context.Positions.Count() == 0)
            {
                var positions = new List<Position>
                {
                    new Position
                    {
                        Id = Guid.NewGuid(),
                        name = "Director"
                    },
                    new Position
                    {
                        Id = Guid.NewGuid(),
                        name = "Operation Executive"
                    },
                    new Position
                    {
                        Id = Guid.NewGuid(),
                        name = "Account Manager"
                    },
                    new Position
                    {
                        Id = Guid.NewGuid(),
                        name = "Accountant"
                    },
                    new Position
                    {
                        Id = Guid.NewGuid(),
                        name = "General Director"
                    },
                    new Position
                    {
                        Id = Guid.NewGuid(),
                        name = "Oversea Manager"
                    },
                    new Position
                    {
                        Id = Guid.NewGuid(),
                        name = "Staff"
                    },
                    new Position
                    {
                        Id = Guid.NewGuid(),
                        name = "FLC"
                    },
                    new Position
                    {
                        Id = Guid.NewGuid(),
                        name = "Nomination"
                    }
                };
                context.Positions.AddRange(positions);
            }
            if (context.Departments.Count() == 0)
            {
                var departments = new List<Department>
                {
                    new Department
                    {
                        Id = Guid.NewGuid(),
                        _key = "DP001",
                        name = "BOD"
                    },
                      new Department
                    {
                        Id = Guid.NewGuid(),
                        _key = "DP002",
                        name = "Sales"
                    },
                      new Department
                    {
                        Id = Guid.NewGuid(),
                        _key = "DP003",
                        name = "Accounting"
                    },
                      new Department
                    {
                        Id = Guid.NewGuid(),
                        _key = "DP004",
                        name = "Operation"
                    },
                      new Department
                    {
                        Id = Guid.NewGuid(),
                        _key = "DP005",
                        name = "Oversea"
                    },
                      new Department
                    {
                        Id = Guid.NewGuid(),
                        _key = "DP006",
                        name = "HAN Office"
                    },
                      new Department
                    {
                        Id = Guid.NewGuid(),
                        _key = "DP007",
                        name = "FLC"
                    },
                      new Department
                    {
                        Id = Guid.NewGuid(),
                        _key = "DP008",
                        name = "Nomination"
                    }
                };
                context.Departments.AddRange(departments);
            }
            context.SaveChanges();
        }
    }
    }

}
