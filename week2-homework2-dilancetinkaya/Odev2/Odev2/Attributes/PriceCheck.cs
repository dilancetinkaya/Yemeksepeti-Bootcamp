using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Odev2.Attributes
{

    public class PriceCheck : ValidationAttribute
    {
        private int _minValue;

        public PriceCheck(int min)
        {
            _minValue = min;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            AdvertisementRequest adModel = (AdvertisementRequest)validationContext.ObjectInstance;

             if (adModel.Price < _minValue)
            {
                return new ValidationResult(FormatErrorMessage(validationContext.MemberName));
            }

            return ValidationResult.Success;
        }
    }
}
