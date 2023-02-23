using Catalog.Host.Models.Dtos;

namespace Catalog.Host.Services.Interfaces;

public interface ICatalogSubCategoryService
{
    Task<int?> Add(string category, int catalogCategoryId);
    Task<bool?> Delete(int id);
    Task<CatalogSubCategoryDto> Update(int id, string category, int catalogCategoryId);
}
