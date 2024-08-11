namespace CQRS.Presentation.Infrastructure.Commands;

public class AddProductCommandRequest: IRequest<string>
{
    public string Title { get; set; } = default!;
}
