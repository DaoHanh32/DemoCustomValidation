using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoValidatorCustom.Shared.Models
{
    public class UsernameValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!value.ToString().ToLower().Contains("Admin"))
            {
                return null;
            }

            return new ValidationResult("The username cannot contain the word admin",new[] {validationContext.MemberName});
        }
    }
}
