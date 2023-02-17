using MailKit.Net.Smtp;
using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Abstractions;
using Queue.Sample.Consumer.IntegrationEvents.Events;

namespace Queue.Sample.Consumer.IntegrationEvents.EventHandling
{
    public class TestIntegrationEventHandler : IIntegrationEventHandler<TestIntegrationEvent>
    {
        private readonly ILogger<TestIntegrationEventHandler> _logger;

        public TestIntegrationEventHandler(
            ILogger<TestIntegrationEventHandler> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task Handle(TestIntegrationEvent @event)
        {
            var mailkit = new SmtpClient();
            await Task.Delay(10000);
            _logger.LogInformation($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} {@event.Id} Handle Method");
        }
    }
}
