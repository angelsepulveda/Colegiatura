namespace Entities.Abstractions.POCOEntities
{
    public abstract class Entity
    {
        public Id Id { get; protected set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }

        protected Entity(Id id)
        {
            Id = id;
        }
    }
}
