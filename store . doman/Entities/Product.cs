using store.Domain.Entities;
using store_._doman.Common;

namespace store_._doman.Entities;

public class Product : BaseEntitiy
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int Stock { get; set; }

    public string? Imageurl { get; set; }

    public int CategoryId { get; set; }

    public Category Category { get; set; } 

        }
