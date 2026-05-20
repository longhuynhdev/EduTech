using System.ComponentModel.DataAnnotations;

namespace EduTech.Attributes;

public class StartDateValidationAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is not DateOnly startDate) return null;

        if (startDate < DateOnly.FromDateTime(DateTime.Now))
            return new ValidationResult("Ngày bắt đầu không được bé hơn ngày hiện tại");

        return ValidationResult.Success;
    }
}