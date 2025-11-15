Console.Clear();
Console.Write("Enter First Reading: ");
var firstReadingValid = int.TryParse(Console.ReadLine(), out int firstReading) ;
Console.WriteLine();
Console.Write("Enter Second Reading: ");
var secondReadingValid = int .TryParse( Console.ReadLine(), out int secondReading);
var result = secondReading - firstReading;
Console.WriteLine($"Usage: {result}");


