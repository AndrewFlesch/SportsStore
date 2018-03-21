using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if(!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A boat for one person",
                        Category = "Watersports",
                        Price = 275
                    },
                     new Product
                     {
                         Name = "Lifejacket",
                         Description = "A boat for one person",
                         Category = "Watersports",
                         Price = 48.95m
                     },
                     new Product
                     {
                         Name = "Bench Press",
                         Description = "used for weight lifting",
                         Category = "Fitness",
                         Price = 20.95m
                     },
                      new Product
                      {
                          Name = "Punching Bag",
                          Description = "used for training",
                          Category = "Boxing",
                          Price = 20.95m
                      },
                      new Product
                      {
                          Name = "Soccer Ball",
                          Description = "A boat for one person",
                          Category = "Sports",
                          Price = 19.50m
                      }
                    );
                context.SaveChanges();
            }
        }
    }
}
