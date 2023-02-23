using Catalog.Host.Data.Entities;

namespace Catalog.Host.Data;

public static class DbInitializer
{
    public static async Task Initialize(ApplicationDbContext context)
    {
        await context.Database.EnsureCreatedAsync();

        if (!context.CatalogBrands.Any())
        {
            await context.CatalogBrands.AddRangeAsync(GetPreconfiguredCatalogBrands());

            await context.SaveChangesAsync();
        }

        if (!context.CatalogCategories.Any())
        {
            await context.CatalogCategories.AddRangeAsync(GetPreconfiguredCatalogCategories());

            await context.SaveChangesAsync();
        }

        if (!context.CatalogSubCategories.Any())
        {
            await context.CatalogSubCategories.AddRangeAsync(GetPreconfiguredCatalogSubCategories());

            await context.SaveChangesAsync();
        }

        if (!context.CatalogItems.Any())
        {
            await context.CatalogItems.AddRangeAsync(GetPreconfiguredItems());

            await context.SaveChangesAsync();
        }
    }

    private static IEnumerable<CatalogBrandEntity> GetPreconfiguredCatalogBrands()
    {
        return new List<CatalogBrandEntity>()
        {
            new CatalogBrandEntity() { Title = "BMW" },
            new CatalogBrandEntity() { Title = "AUDI" },
            new CatalogBrandEntity() { Title = "FORD" },
            new CatalogBrandEntity() { Title = "MB" },
            new CatalogBrandEntity() { Title = "Lamborgini" },
            new CatalogBrandEntity() { Title = "RENAULT" },
            new CatalogBrandEntity() { Title = "YAMAHA" }
        };
    }

    private static IEnumerable<CatalogCategoryEntity> GetPreconfiguredCatalogCategories()
    {
        return new List<CatalogCategoryEntity>()
        {
            new CatalogCategoryEntity() { Title = "Truck" },
            new CatalogCategoryEntity() { Title = "Passenger car" },
            new CatalogCategoryEntity() { Title = "SUV" },
            new CatalogCategoryEntity() { Title = "Moto" },
            new CatalogCategoryEntity() { Title = "Sport car" }
        };
    }

    private static IEnumerable<CatalogSubCategoryEntity> GetPreconfiguredCatalogSubCategories()
    {
        return new List<CatalogSubCategoryEntity>()
        {
            new CatalogSubCategoryEntity() { Title = "Lorry", CatalogCategoryId = 1 },
            new CatalogSubCategoryEntity() { Title = "Vagon", CatalogCategoryId = 1 },
            new CatalogSubCategoryEntity() { Title = "Station wagon", CatalogCategoryId = 2 },
            new CatalogSubCategoryEntity() { Title = "Subcompact car", CatalogCategoryId = 2 },
            new CatalogSubCategoryEntity() { Title = "Family car", CatalogCategoryId = 2 },
            new CatalogSubCategoryEntity() { Title = "Cabrio", CatalogCategoryId = 2 },
            new CatalogSubCategoryEntity() { Title = "SUV", CatalogCategoryId = 3 },
            new CatalogSubCategoryEntity() { Title = "Crossover", CatalogCategoryId = 3 },
            new CatalogSubCategoryEntity() { Title = "Pickup", CatalogCategoryId = 3 },
            new CatalogSubCategoryEntity() { Title = "Sport", CatalogCategoryId = 4 },
            new CatalogSubCategoryEntity() { Title = "Choper", CatalogCategoryId = 4 },
            new CatalogSubCategoryEntity() { Title = "Moped", CatalogCategoryId = 4 },
            new CatalogSubCategoryEntity() { Title = "Electro", CatalogCategoryId = 5 },
            new CatalogSubCategoryEntity() { Title = "Luxury", CatalogCategoryId = 5 },
            new CatalogSubCategoryEntity() { Title = "Sport", CatalogCategoryId = 5 }
        };
    }

    private static IEnumerable<CatalogItemEntity> GetPreconfiguredItems()
    {
        return new List<CatalogItemEntity>()
        {
            new CatalogItemEntity() { Title = "Mercedes-Benz Actross", PictureFileName = "1.png", Price = 100000M, AvailableStock = 3, CatalogBrandId = 1, CatalogSubCategoryId = 1, Description = "Новый грузовик" },
            new CatalogItemEntity() { Title = "Renault Master", PictureFileName = "2.png", Price = 20000M, AvailableStock = 10, CatalogBrandId = 5, CatalogSubCategoryId = 2, Description = "Очень вместительный фургон" },
            new CatalogItemEntity() { Title = "Audi TT", PictureFileName = "3.png", Price = 35000M, AvailableStock = 1, CatalogBrandId = 2, CatalogSubCategoryId = 6, Description = "Новый спортивный кабриолет" },
            new CatalogItemEntity() { Title = "Ford Ranger", PictureFileName = "4.png", Price = 60000M, AvailableStock = 2, CatalogBrandId = 3, CatalogSubCategoryId = 9, Description = "Пикап на все случаи жизни" },
            new CatalogItemEntity() { Title = "Audi Q5", PictureFileName = "8.png", Price = 50000M, AvailableStock = 2, CatalogBrandId = 2, CatalogSubCategoryId = 8, Description = "Стильный кроссовер" },
            new CatalogItemEntity() { Title = "Yamaha R1", PictureFileName = "5.png", Price = 15500M, AvailableStock = 5, CatalogBrandId = 7, CatalogSubCategoryId = 10, Description = "Мот для настоящих экстрималов" },
            new CatalogItemEntity() { Title = "Yamaha", PictureFileName = "6.png", Price = 22500M, AvailableStock = 1, CatalogBrandId = 7, CatalogSubCategoryId = 11, Description = "Чопер для злых мужиков" },
            new CatalogItemEntity() { Title = "BMW X7", PictureFileName = "7.png", Price = 150000M, AvailableStock = 1, CatalogBrandId = 1, CatalogSubCategoryId = 14, Description = "Люксовый внедорожник" },
            new CatalogItemEntity() { Title = "Audi RS", PictureFileName = "9.png", Price = 100000M, AvailableStock = 1, CatalogBrandId = 2, CatalogSubCategoryId = 13, Description = "Новый спортивный електромобиль" },
            new CatalogItemEntity() { Title = "Lamborgini Huracan", PictureFileName = "10.png", Price = 300000M, AvailableStock = 0, CatalogBrandId = 5, CatalogSubCategoryId = 15, Description = "Только под заказ" }
        };
    }
}