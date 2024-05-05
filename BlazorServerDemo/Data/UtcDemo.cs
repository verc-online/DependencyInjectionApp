namespace BlazorServerDemo.Data
{
    public class UtcDemo : IDemo, IUtcDemo
    {
        public DateTime StartUpTime { get; init; }

        public UtcDemo()
        {
            StartUpTime = DateTime.UtcNow;
        }
    }
}
