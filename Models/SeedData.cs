using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NidhisRuler.Data;

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
                        Price = 2.00M
                    },
                    new Ruler
                    {
                        Type = "Scale",
                        Shape = "Rectangle",
                        Material = "Wooden",
                        Measurement = "Centimetre",
                        Color = "Yellow",
                        Use = "School purpose",
                        Price = 2.00M
                    },
                    new Ruler
                    {
                        Type = "Circle Ruler",
                        Shape = "Round",
                        Material = "Plastic",
                        Measurement = "Meter",
                        Color = "White",
                        Use = "Mechanical Class",
                        Price = 3.05M
                    },
                    new Ruler
                    {
                        Type = "Circle Ruler",
                        Shape = "Round",
                        Material = "Plastic",
                        Measurement = "Meter",
                        Color = "White",
                        Use = "Mechanical Class",
                        Price = 3.05M
                    },
                    new Ruler
                    {
                        Type = "Triangle Ruler",
                        Shape = "Triangle",
                        Material = "Plastic",
                        Measurement = "Centimetre",
                        Color = "White",
                        Use = "School purpose",
                        Price = 2.59M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
