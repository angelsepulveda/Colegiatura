namespace People.BusinessObjects.DocumentTypes.Interfaces.Repositories;

public interface IDocumentTypeCommandRepository
{
    void Add(DocumentType documentType);
    void Update(DocumentType documentType);
    void Delete(DocumentType documentType);
}
