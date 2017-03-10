using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace TakeVacation.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Egypt",
                        Description = "Pyramids and museum tour",
                        Category = "Africa",
                        Price = 1500
                    },

                     new Product
                     {
                         Name = "Kenya",
                         Description = "Safari, elephant watch",
                         Category = "Africa",
                         Price = 1200
                     },

                      new Product
                      {
                          Name = "USA and Canada West",
                          Description = "West Coast tour",
                          Category = "Americas",
                          Price = 500
                      },

                       new Product
                       {
                           Name = "USA and Canada East",
                           Description = "East Coast tour",
                           Category = "Americas",
                           Price = 500
                       },

                       new Product
                       {
                           Name = "USA and Canada Central",
                           Description = "Between the coasts tour",
                           Category = "Americas",
                           Price = 500
                       },

                       new Product
                       {
                           Name = "Canada All",
                           Description = "Coast to coast tour",
                           Category = "Americas",
                           Price = 1500
                       },

                       new Product
                       {
                           Name = "Alaska",
                           Description = "Alaska wildlife tour",
                           Category = "Americas",
                           Price = 1000
                       },

                       new Product
                       {
                           Name = "USA All",
                           Description = "USA Coast to Coast tour",
                           Category = "Americas",
                           Price = 1500
                       },

                       new Product
                       {
                           Name = "USA Entertainment",
                           Description = "Disneyland, Niagara, Hollywood, Las Vegas tour",
                           Category = "Americas",
                           Price = 1500
                       },

                        new Product
                        {
                            Name = "India South",
                            Description = "Eastern and Western ghat, magnificient Kerala",
                            Category = "Asia",
                            Price = 1500
                        },

                         new Product
                         {
                             Name = "India Royal",
                             Description = "Palace on the Wheels Train tour",
                             Category = "Asia",
                             Price = 1500
                         },

                          new Product
                          {
                              Name = "India Himalayas",
                              Description = "North and East Indian Himalayas tour",
                              Category = "Asia",
                              Price = 1500
                          },

                          new Product
                          {
                              Name = "India Coast",
                              Description = "Goa, Mumbai, Pondicherry, Chennai, Puri",
                              Category = "Asia",
                              Price = 1500
                          },

                           new Product
                           {
                               Name = "East Asia",
                               Description = "Malayasia, Hong Kong, Thailand cruise",
                               Category = "Asia",
                               Price = 1500
                           },

                           new Product
                           {
                               Name = "China",
                               Description = "Great Wall, Beijing, and Shanghai tour",
                               Category = "Asia",
                               Price = 1500
                           },

                           new Product
                           {
                               Name = "UK and Ireland",
                               Description = "London, Glasgow, Scotland wilderness, Dublin, Irish hills and all coast tour",
                               Category = "Europe",
                               Price = 900
                           },

                           new Product
                           {
                               Name = "Europe Grand",
                               Description = "Euro Rail tour to France, Germany, Romania, Bulgaria, Italy, Spain",
                               Category = "Europe",
                               Price = 1000
                           },

                           new Product
                           {
                               Name = "Scandanavia",
                               Description = "Norway, Sweden, Switzerland, and Netherlands tour",
                               Category = "Europe",
                               Price = 1500
                           },

                           new Product
                           {
                               Name = "Russia",
                               Description = "Moscow, St Petersburg, Siberia tour",
                               Category = "Europe",
                               Price = 1000
                           }
                    );
                context.SaveChanges();
            }
        }
    }
}
