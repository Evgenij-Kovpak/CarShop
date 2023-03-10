using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Catalog.Host.Models.Requests;

public class CreateSubCategoryRequest
{
    [Required(ErrorMessage = "Fill in this field")]
    [StringLength(50, ErrorMessage = "Title length can't be more than 50.")]
    public string Title { get; set; } = null!;

    [Required(ErrorMessage = "Fill in this field")]
    [Display(Name = "Category Id")]
    public int CategoryId { get; set; }
}
