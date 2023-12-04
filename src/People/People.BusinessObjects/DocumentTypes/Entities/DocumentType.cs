namespace People.BusinessObjects.DocumentTypes;

public sealed class DocumentType : Entity
{
    public DocumentType(Id id)
        : base(id) { }

    public DocumentType(Id id, string name, string? description, bool isDeleted)
        : base(id)
    {
        Name = name;
        Description = description;
        IsDeleted = isDeleted;
    }

    public string Name { get; private set; } = null!;
    public string? Description { get; private set; }
    public bool IsDeleted { get; private set; }

    public void Update(string name, string? description)
    {
        if (name != Name)
            Name = name;

        if (description != Description)
            Description = description;
    }

    public void Delete()
    {
        if (!IsDeleted)
            throw new InvalidOperationException("Document type is already deleted.");

        IsDeleted = true;
    }

    public void Restore()
    {
        if (IsDeleted)
            throw new InvalidOperationException("Document type is already restored.");

        IsDeleted = false;
    }
}
