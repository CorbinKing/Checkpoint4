//Authors: Corbin King, Jake Saylor, Mikey Jenkins, Peter Madsen

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOut.Models.Validations
{
    public class PriceRange : ValidationAttribute
    {
        //I played around with a couple of custom validations and they seem to work fine
        //This one is to verify that the user enters a number for the price and not a string
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