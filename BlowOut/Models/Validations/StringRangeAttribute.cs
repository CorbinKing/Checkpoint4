//Authors: Corbin King, Jake Saylor, Mikey Jenkins, Peter Madsen

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOut.Models.Validations
{ 
        public class StringRangeAttribute : ValidationAttribute
        {
        //I played around with a couple of custom validations and they seem to work fine
        //This one is to verify that the user enters only a specified value for the instruments that we already have images of. Otherwise it would break the dynamic images
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {

                if (value.ToString() == "Clarinet" || value.ToString() == "Flute" || value.ToString() == "Saxophone" || value.ToString() == "Trombone" || value.ToString() == "Trumpet" || value.ToString() == "Tuba")
                {
                    return ValidationResult.Success;
                }


                return new ValidationResult("Please enter Clarinet, Flute, Saxophone, Trombone, Trumpet, or Tuba");
            }
        }
}