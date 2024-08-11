namespace CQRS.Presentation.Infrastructure.Handlers;

public class AddProductCommandHandler : IRequestHandler<AddProductCommandRequest, string>
{
    public Task<string> Handle
        (AddProductCommandRequest request, CancellationToken cancellationToken)
    {
        return Task.FromResult($"Product Added...! -- Product Name : {request.Title}");
    }
}
