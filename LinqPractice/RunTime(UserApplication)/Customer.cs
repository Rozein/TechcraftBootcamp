using System.ComponentModel.DataAnnotations;

namespace RunTime_UserApplication_
{
    public class Customer
    {
        public CustomerEnum CustomerId { get; set; }
        [Required]
        public string Fullname { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public long MobileNumber { get; set; }
        [RequireWhenCustomer]
        public int? BillNumber { get; set; }
        [RequireWhenCustomer]
        public int? BillAmount { get; set; }
 

        public class RequireWhenCustomerAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                var customer = (Customer)validationContext.ObjectInstance;
                if (customer.CustomerId == CustomerEnum.Admin)
                    return ValidationResult.Success;

                if (int.TryParse(value as string, out int intValue))
                {
                    // Successfully parsed intValue from the string
                    return intValue == 0
                        ? new ValidationResult("Value greater than 0 is required.")
                        : ValidationResult.Success;
                }
                else
                {
                    // Failed to parse intValue from the string
                    return new ValidationResult("Invalid integer value.");
                }
            }
        }

        public enum CustomerEnum{
            Customer = 1,
            Admin = 2
        }
    }
}
