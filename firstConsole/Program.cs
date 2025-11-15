Console.Clear();
Console.Write("Enter First Reading: ");
var firstReadingValid = int.TryParse(Console.ReadLine(), out int firstReading) ;
Console.WriteLine();
Console.Write("Enter Second Reading: ");
var secondReadingValid = int .TryParse( Console.ReadLine(), out int secondReading);

if (firstReadingValid && secondReadingValid)
{
    var firstPowerReading = new PowerReading { Reading =  firstReading, RecordedOn = DateTime.Parse("01/06/2025")};
    var lastPowerReading = new PowerReading { Reading=  secondReading, RecordedOn = DateTime.Parse("01/12/2025")};

    Console.WriteLine($"Using PowerReading: { PowerReading.Usage(firstPowerReading, lastPowerReading)}");    
}
else
{
    Console.WriteLine("Invalid Readings submitted.");
}


