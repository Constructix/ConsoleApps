using firstConsole.Validators;
using FluentValidation.Results;

    Console.Clear();
    var firstPowerReading = InputReading("Enter First Reading: ");
    var secondPowerReading = InputReading("Enter Second Reading: ");
    
    var validator = new PowerReadingValdiator();
    
    var firstReadingIsValid = validator.Validate(firstPowerReading);
    var secondReadingIsValid = validator.Validate(secondPowerReading);

    if (firstReadingIsValid.IsValid && secondReadingIsValid.IsValid)
    {
        Console.WriteLine($"Using PowerReading: {PowerReading.Usage(firstPowerReading, secondPowerReading).Usage}");
        Console.WriteLine($"Using Days: {PowerReading.Usage(firstPowerReading, secondPowerReading).DaysBetweenReadings}");
    }
    else
        DisplayValidationErrors(firstReadingIsValid, secondReadingIsValid);

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

PowerReading InputReading(string inputPrompt)
{
    Console.Write($"{inputPrompt}");
    int.TryParse(Console.ReadLine(), out int readingValue ) ;
    Console.WriteLine();
    Console.Write("Enter Reading Date:");
    DateTime.TryParse(Console.ReadLine(), out DateTime recordedDateTime);
    return new  PowerReading { Reading = readingValue,  RecordedOn = recordedDateTime= recordedDateTime };
}