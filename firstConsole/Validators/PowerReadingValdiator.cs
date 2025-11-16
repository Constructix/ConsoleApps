using FluentValidation;

namespace firstConsole.Validators;

public class PowerReadingValdiator : AbstractValidator<PowerReading>
{
    public PowerReadingValdiator()
    {
        
        RuleFor(r=>r.Reading).GreaterThan(0).WithMessage("Reading must be greater than zero.");
        
        RuleFor(r => r.RecordedOn.Date)
            .LessThanOrEqualTo(DateTime.Today)
            .WithMessage("RecordedOn must be less than or equal to today's date.");
    }
}