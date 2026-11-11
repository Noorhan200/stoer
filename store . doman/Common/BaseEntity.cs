namespace store_._doman.Common;

public abstract class BaseEntitiy
{
    public int Id { get; protected set; }

public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAd { get; set; }

    public bool IsDeleted { get; set; }
}