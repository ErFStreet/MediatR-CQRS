namespace CQRS.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("AddProduct")]
    public async Task<IActionResult> AddProductAsync([FromBody]
        AddProductCommandRequest request, CancellationToken cancellationToken)
    {
        try
        {
            return Ok(new { Message = await _mediator.Send(request, cancellationToken) });
        }
        catch (Exception)
        {
            return StatusCode(404);
        }
    }
}
