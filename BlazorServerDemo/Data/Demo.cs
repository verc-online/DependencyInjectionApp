namespace BlazorServerDemo.Data
{
    public class Demo : IDemo, ILocalDemo, IDisposable
    {
        private readonly ILogger<Demo> _log;

        public DateTime StartUpTime { get; init; }

        public Demo(ILogger<Demo> log)
        {
            StartUpTime = DateTime.Now;
            _log = log;
        }

        public void Dispose()
        {
            _log.LogError($"Demo ({StartUpTime:hh:mm:ss fffffff}) was disposed of");
        }
    }
}
