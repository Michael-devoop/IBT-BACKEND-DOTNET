using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace AddisEats.Api.Validation;

public class ETBAmountAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(
        object? value,
        ValidationContext validationContext)
    {
        if (value is null)
            return ValidationResult.Success;
        if (value is not decimal amount || amount <= 0m)
        {
            return new ValidationResult(
                "Amount must be greter then Zero.");
        }
        if (decimal.Round(amount,2)!=amount)
        {
            return new ValidationResult("amount cannot have more than two decimal palces.");
        }
        return ValidationResult.Success;
    }

}