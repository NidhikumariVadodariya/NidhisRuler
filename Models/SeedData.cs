using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NidhisRuler.Data;

// Data Seeded for my Ruler's properties

namespace NidhisRuler.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Ruler.Any())
                {
                    return;   // DB has been seeded
                }

                context.Ruler.AddRange(
                    new Ruler
                    {
                        Type = "Scale",
                        Shape = "Rectangle",
                        Material = "Wooden",
                        Measurement = "Centimetre",
                        Color = "Yellow",
                        Use = "School purpose",
                        Price = 2.00M,
                        Rating = 1.5M // Last added manually while part 8 for adding new field manually
                    },
                    new Ruler
                    {
                        Type = "Scale",
                        Shape = "Rectangle",
                        Material = "Wooden",
                        Measurement = "Centimetre",
                        Color = "Yellow",
                        Use = "School purpose",
                        Price = 2.00M,
                        Rating = 1.5M
                    },
                    new Ruler
                    {
                        Type = "Circle Ruler",
                        Shape = "Round",
                        Material = "Plastic",
                        Measurement = "Meter",
                        Color = "White",
                        Use = "Mechanical Class",
                        Price = 3.05M,
                        Rating = 1.5M
                    },
                    new Ruler
                    {
                        Type = "Circle Ruler",
                        Shape = "Round",
                        Material = "Plastic",
                        Measurement = "Meter",
                        Color = "White",
                        Use = "Mechanical Class",
                        Price = 3.05M,
                        Rating = 1.5M
                    },
                    new Ruler
                    {
                        Type = "Triangle Ruler",
                        Shape = "Triangle",
                        Material = "Plastic",
                        Measurement = "Centimetre",
                        Color = "White",
                        Use = "School purpose",
                        Price = 2.59M,
                        Rating = 1.5M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
