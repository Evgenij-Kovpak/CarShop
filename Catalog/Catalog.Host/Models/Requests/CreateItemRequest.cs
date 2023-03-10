using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Catalog.Host.Models.Requests;

public class CreateItemRequest
{
    [Required(ErrorMessage = "Fill in this field")]
    [StringLength(50, ErrorMessage = "Title length can't be more than 50.")]
    public string Title { get; set; } = null!;

    [Required(ErrorMessage = "Fill in this field")]
    [StringLength(1000, ErrorMessage = "Description length can't be more than 1000.")]
    public string Description { get; set; } = null!;

    [Required(ErrorMessage = "Fill in this field")]
    [FileExtensions(ErrorMessage = "Please specify a valid image file (.jpg, .jpeg, .gif or .png)")]
    [Display(Name = "Name of picture file")]
    public string PictureFileName { get; set; } = null!;

    [Required(ErrorMessage = "Fill in this field")]
    [Range(5, 10000000, ErrorMessage = "Value for price must be between 5 and 10000000.")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Fill in this field")]
    [Display(Name = "Available stock")]
    public int AvailableStock { get; set; }

    [Required(ErrorMessage = "Fill in this field")]
    [Display(Name = "Brand Id")]
    public int CatalogBrandId { get; set; }

    [Required(ErrorMessage = "Fill in this field")]
    [Display(Name = "SubCategory Id")]
    public int CatalogSubCategoryId { get; set; }
}
