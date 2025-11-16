using firstConsole.Validators;
using FluentValidation.Results;

Console.Clear();
Console.Write("Enter First Reading: ");
var firstReadingValid = int.TryParse(Console.ReadLine(), out int firstReading ) ;
Console.WriteLine();
Console.Write("Enter Second Reading: ");
var secondReadingValid = int .TryParse( Console.ReadLine(), out int secondReading);

var datecompareresult = DateTime.Parse("01/12/2026").ToUniversalTime().Date.CompareTo(DateTime.Now.ToUniversalTime().Date); 
Console.WriteLine(datecompareresult.ToString());

if (firstReadingValid && secondReadingValid)
{
    var firstPowerReading = new PowerReading { Reading = firstReading, RecordedOn = DateTime.Parse("01/06/2025") };
    var lastPowerReading = new PowerReading { Reading = secondReading, RecordedOn = DateTime.Today };

    var validator = new PowerReadingValdiator();
    var firstReadingIsValid = validator.Validate(firstPowerReading);
    var secondReadingIsValid = validator.Validate(lastPowerReading);
    
    Console.WriteLine(lastPowerReading.RecordedOn);
    if (firstReadingIsValid.IsValid && secondReadingIsValid.IsValid)
        Console.WriteLine($"Using PowerReading: {PowerReading.Usage(firstPowerReading, lastPowerReading)}");
    else
    {
        DisplayValidationErrors(firstReadingIsValid, secondReadingIsValid);
    }
}
else
{
    Console.WriteLine("Readings must be integer.");
}

void DisplayValidationErrors(ValidationResult validationResult, ValidationResult secondReadingIsValid1)
{
    foreach (var validationFailure in validationResult.Errors)
    {
        Console.WriteLine(validationFailure.ErrorMessage);
    }

    foreach (var validationFailure in secondReadingIsValid1.Errors)
    {
        Console.WriteLine(validationFailure.ErrorMessage);
    }
}