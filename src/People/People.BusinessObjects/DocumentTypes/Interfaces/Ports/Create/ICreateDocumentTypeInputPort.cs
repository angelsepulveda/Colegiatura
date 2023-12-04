namespace People.BusinessObjects.DocumentTypes.Interfaces.Ports.Create;

public interface ICreateDocumentTypeInputPort
{
    ValueTask Handle(CreateDocumentTypeDto createDocumentTypeDto);
}
