using DiDemoLib;

namespace WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IMessages _messages;

        public Worker(ILogger<Worker> logger, IMessages messages)
        {
            _logger = logger;
            _messages = messages;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogError(_messages.sayHello());
                _logger.LogError(_messages.sayGoodBye());
                await Task.Delay(3000, stoppingToken);
            }
        }
    }
}
