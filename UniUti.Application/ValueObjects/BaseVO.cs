namespace UniUti.Application.ValueObjects
{
    public abstract class BaseVO
    {
        public string? Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
