using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Catalog.Host.Models.Requests;

public class PaginatedItemsRequest<T>
    where T : notnull
{
    [Required(ErrorMessage = "Fill in this field")]
    [Display(Name = "Page index")]
    public int PageIndex { get; set; }

    [Required(ErrorMessage = "Fill in this field")]
    [Display(Name = "Page size")]
    public int PageSize { get; set; }

    [Required(ErrorMessage = "Fill in this field")]
    public Dictionary<T, int>? Filters { get; set; }
}