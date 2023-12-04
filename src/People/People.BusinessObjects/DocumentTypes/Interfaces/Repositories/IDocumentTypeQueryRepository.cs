namespace People.BusinessObjects.DocumentTypes.Interfaces.Repositories;

public interface IDocumentQueryRepository
{
    ValueTask<DocumentType?> GetById(Id id);
    ValueTask<IEnumerable<DocumentType>> GetAll();
}
