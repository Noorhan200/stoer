using store_._doman.Common;
using store_._doman.Entities;

namespace store.Domain.Entities;

public class Category : BaseEntitiy
{
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public ICollection<Product> prodects { get; set; } = new List<Product>();
}