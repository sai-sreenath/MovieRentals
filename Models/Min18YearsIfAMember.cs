using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoRentals.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //First,need to check the selected membership type
            var customer = (Customer) validationContext.ObjectInstance;

            if(customer.MemberShipTypeId==MembershipType.unknown || customer.MemberShipTypeId==MembershipType.PayAsYouGo)
                return ValidationResult.Success;
            if(customer.Birthdate==null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should be atleast 18 years older to go on a membership.");
        }
    }
}