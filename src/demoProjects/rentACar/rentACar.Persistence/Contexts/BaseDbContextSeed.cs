using rentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar.Persistence.Contexts
{
    public class BaseDbContextSeed
    {
        public static async Task SeedAsync(BaseDbContext baseContext)
        {
            if (!baseContext.Brands.Any())
            {
                baseContext.Brands.AddRange(GetPreconfiguredBrands());

                await baseContext.SaveChangesAsync();
            }

            if (!baseContext.Models.Any())
            {
                baseContext.Models.AddRange(GetPreconfiguredModels());

                await baseContext.SaveChangesAsync();
            }
        }

        private static IEnumerable<Brand> GetPreconfiguredBrands()
        {
            return new List<Brand>()
            {
               new Brand()
               {
                  Name = "Mercedes"
               },
               new Brand()
               {
                  Name = "BMW"
               }
            };
        }

        private static IEnumerable<Model> GetPreconfiguredModels()
        {
            return new List<Model>()
            {
                new Model()
                {
                    BrandId = 1,
                    Name = "SClass Series",
                    DailyPrice = 5000,
                    ImageUrl = "tempUrl",

                },
                new Model()
                {
                    BrandId = 2,
                    Name = "E1 Series",
                    DailyPrice = 2500,
                    ImageUrl = "tempUrl",

                }
               
            };
        }

    }
}
