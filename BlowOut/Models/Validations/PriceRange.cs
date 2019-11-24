using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOut.Models.Validations
{
    public class PriceRange : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string x = value.ToString();
            int number;

            if (int.TryParse(x, out number))
            {
                return ValidationResult.Success;
            }


            return new ValidationResult("Please enter a number");
        }
    }
}