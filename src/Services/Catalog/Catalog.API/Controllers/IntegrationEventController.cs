namespace Microsoft.eShopOnDapr.Services.Catalog.API.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class IntegrationEventController : ControllerBase
{
    private const string DAPR_PUBSUB_NAME = "pubsub";

    [HttpPost("HandleIntegrationEvent")]
    [Topic(DAPR_PUBSUB_NAME, nameof(IntegrationEvent))]
    public Task HandleAsync(IntegrationEvent @event) =>
        Task.CompletedTask;
}
