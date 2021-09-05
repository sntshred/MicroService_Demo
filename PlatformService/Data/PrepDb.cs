using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PlatformService.Models;

namespace PlatformService.Data
{

  public static class PrepDb
  {
    // creating AppDbContext dependency injection manually, because this is static class
    public static void PrepPopulation(IApplicationBuilder app)
    {
      using (var serviceScope = app.ApplicationServices.CreateScope())
      {

        SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
      }

    }

    private static void SeedData(AppDbContext context)
    {
      if (!context.Platforms.Any())
      {
        Console.WriteLine("Seeding Data");

        context.Platforms.AddRange(
          new Platform { Name = "Windows", Publisher = "Microsoft", Cost = "Free" },
          new Platform { Name = "Linux", Publisher = "Linux", Cost = "Free" },
          new Platform { Name = "Mac", Publisher = "Apple", Cost = "Free" },
          new Platform { Name = "Android", Publisher = "Google", Cost = "Free" },
          new Platform { Name = "iOS", Publisher = "Apple", Cost = "200" }
        );
        context.SaveChanges();
      }
      else
      {
        Console.WriteLine("Platforms already exist");
      }

    }
  }
}