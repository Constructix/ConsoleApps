public class PowerReading
{
    public int Reading { get; init; } = 0;
    public DateTime RecordedOn { get; init; } = DateTime.Now;
    public static int Usage(PowerReading first, PowerReading last) => last.Reading - first.Reading;
}