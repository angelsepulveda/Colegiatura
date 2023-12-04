namespace Entities.Abstractions.ValueObjects
{
    public class Id
    {
        public Guid Value { private set; get; }

        public Id(Guid value)
        {
            Value = value;
        }

        public static Id NewId() => new(Guid.NewGuid());
    }
}
