using InterdanTest.Common.Enums;
using InterdanTest.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace InterdanTest.Data
{
    public static class InterdanTestDbContextBuilderExtensions
    {
        public static IApplicationBuilder UseInterdanTestDbData(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                var context = services.GetRequiredService<InterdanTestDbContext>();

                // brands
                context.Brands.Add(new Brand() { Id = 1, Name = "Peugeot" });
                context.Brands.Add(new Brand() { Id = 2, Name = "Citroen" });

                // models
                context.Models.Add(new Model() { Id = 1, BarndId = 1, Type = ModelType.Personal, Name = "208" });
                context.Models.Add(new Model() { Id = 2, BarndId = 1, Type = ModelType.Van,      Name = "Boxer" });
                context.Models.Add(new Model() { Id = 3, BarndId = 2, Type = ModelType.Personal, Name = "C3" });
                context.Models.Add(new Model() { Id = 4, BarndId = 2, Type = ModelType.Van,      Name = "Jumper" });

                // engines
                context.Engines.Add(new Engine() { Id = 1, Name = "1.2 PureTech", Fuel = FuelType.Petrol, Gear = GearType.Manual });
                context.Engines.Add(new Engine() { Id = 2, Name = "1.2 PureTech", Fuel = FuelType.Petrol, Gear = GearType.Automatic });
                context.Engines.Add(new Engine() { Id = 3, Name = "1.5 BlueHDI",  Fuel = FuelType.Diesel, Gear = GearType.Automatic });
                context.Engines.Add(new Engine() { Id = 4, Name = "2.0 BlueHDI",  Fuel = FuelType.Diesel, Gear = GearType.Manual });

                // colors
                context.Colors.Add(new Color() { Id = 1, Name = "White" });
                context.Colors.Add(new Color() { Id = 2, Name = "Black" });

                // Peugeot 108 1.2 PureTech Manual
                context.Cars.Add(new Car() { Id = 1, ModelId = 1, EngineId = 1, Price = 150000 });
                context.CarColors.Add(new CarColor() { Id = 1, CarId = 1, ColorId = 1, Price = 100 });
                context.CarColors.Add(new CarColor() { Id = 2, CarId = 1, ColorId = 2, Price = 50 });

                // Peugeot 108 1.2 PureTech Automatic
                context.Cars.Add(new Car() { Id = 2, ModelId = 1, EngineId = 2, Price = 149500 });
                context.CarColors.Add(new CarColor() { Id = 3, CarId = 2, ColorId = 1, Price = 1000 });
                context.CarColors.Add(new CarColor() { Id = 4, CarId = 2, ColorId = 2, Price = 500 });

                // Peugeot Boxer 2.0 BlueHDI Manual
                context.Cars.Add(new Car() { Id = 3, ModelId = 2, EngineId = 4, Price = 200000 });
                context.CarColors.Add(new CarColor() { Id = 5, CarId = 3, ColorId = 1, Price = 0 });
                context.CarColors.Add(new CarColor() { Id = 6, CarId = 3, ColorId = 2, Price = 100 });

                // Citroen C3 1.2 PureTech Automatic
                context.Cars.Add(new Car() { Id = 4, ModelId = 3, EngineId = 2, Price = 170000 });
                context.CarColors.Add(new CarColor() { Id = 7, CarId = 4, ColorId = 1, Price = 0 });
                context.CarColors.Add(new CarColor() { Id = 8, CarId = 4, ColorId = 2, Price = 500 });

                // Citroen C3 1.5 BlueHDI Automatic
                context.Cars.Add(new Car() { Id = 5, ModelId = 3, EngineId = 3, Price = 169000 });
                context.CarColors.Add(new CarColor() { Id = 9, CarId = 5, ColorId = 1, Price = 1000 });
                context.CarColors.Add(new CarColor() { Id = 10, CarId = 5, ColorId = 2, Price = 1500 });

                context.SaveChanges();
            }

            return app;
        }
    }
}
