public class PowerReading
{
    public int Reading { get; init; } = 0;
    public DateTime RecordedOn { get; init; } = DateTime.Now;

    public static PowerReadingResult Usage(PowerReading first, PowerReading last)
    {
      return new PowerReadingResult() { Usage = last.Reading - first.Reading , DaysBetweenReadings = last.RecordedOn.Date.Subtract(first.RecordedOn).Days };  
    } 
}

public class PowerReadingResult
{
    public int Usage { get; init; }
    public int DaysBetweenReadings { get; init; }
}