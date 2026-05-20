using System.ComponentModel.DataAnnotations;

namespace EduTech.Attributes;

public class EndDateValidationAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is not DateOnly endDate) return null;
        if (endDate < DateOnly.FromDateTime(DateTime.Now))
            return new ValidationResult("Ngày kết thúc không được bé hơn ngày hiện tại");

        return ValidationResult.Success;
    }
}