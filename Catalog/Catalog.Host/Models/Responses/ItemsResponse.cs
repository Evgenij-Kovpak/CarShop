namespace Catalog.Host.Models.Responses;

public class ItemsResponse<T>
{
    public long Count { get; set; }
    public IList<T> Data { get; set; } = new List<T>();
}
