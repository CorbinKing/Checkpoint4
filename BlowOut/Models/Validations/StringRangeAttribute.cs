using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOut.Models.Validations
{ 
        public class StringRangeAttribute : ValidationAttribute
        {
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