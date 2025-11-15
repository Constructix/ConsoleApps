public class PowerReading
{
    public int Reading { get; init; }
    public DateTime RecordedOn { get; init; }
    public static int Usage(PowerReading first, PowerReading last) => last.Reading - first.Reading;
}