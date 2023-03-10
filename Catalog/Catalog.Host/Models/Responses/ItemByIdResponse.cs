using Catalog.Host.Models.Dtos;

namespace Catalog.Host.Models.Responses;

public class ItemByIdResponse
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string PictureFileName { get; set; } = null!;
    public decimal Price { get; set; }
    public int AvailableStock { get; set; }
    public CatalogBrandDto CatalogBrand { get; set; } = null!;
    public CatalogSubCategoryDto CatalogSubCategory { get; set; } = null!;
}
