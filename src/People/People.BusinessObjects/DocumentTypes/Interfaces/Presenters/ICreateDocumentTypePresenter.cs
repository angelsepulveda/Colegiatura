namespace People.BusinessObjects.DocumentTypes.Interfaces.Presenters;

public interface ICreateDocumentTypePresenter : ICreateDocumentTypeOutputPort
{
    ValueTask Handle(Guid documentTypeId);
}
