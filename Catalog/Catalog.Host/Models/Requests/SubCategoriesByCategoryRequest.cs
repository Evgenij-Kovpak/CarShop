using System.ComponentModel.DataAnnotations;

namespace Catalog.Host.Models.Requests;

public class SubCategoriesByCategoryRequest
{
    [Required(ErrorMessage = "Fill in this field")]
    [StringLength(50, ErrorMessage = "Category title length can't be more than 50.")]
    public string Category { get; set; } = null!;
}
