using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace AddisEats.Api.Validation;

public class EthiopianMobileAttribute : ValidationAttribute
{
	private static readonly Regex Pattern =
		new Regex(@"^(09|07)\d{8}$",
           RegexOptions.Compiled);

	public EthiopianMobileAttribute()
	{
		ErrorMessage = "Enter a valid Ethiopian mobile number.";
	}

	protected override ValidationResult? IsValid(
		object? value,
		ValidationContext validationContext)
	{
		if (value is null)
			return ValidationResult.Success;

		if (value is not string phone ||
			!Pattern.IsMatch(phone))
		{
			return new ValidationResult(ErrorMessage);
		}
		return ValidationResult.Success;
	}
}