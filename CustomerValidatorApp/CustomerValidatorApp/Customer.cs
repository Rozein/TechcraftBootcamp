namespace CustomerValidatorApp
{
    public class Customer
    {
        private bool isCustomer;
        public bool IsCustomer
        {
            get { return isCustomer; }
            set
            {
                isCustomer = value;
                if (isCustomer)
                {
                    FullNameRequired = true;
                    AddressRequired = true;
                    MobileNumberRequired = true;
                    BillNumberRequired = true;
                    BillAmountRequired = true;
                }
                else
                {
                    FullNameRequired = true;
                    AddressRequired = true;
                    MobileNumberRequired = true;
                    BillNumberRequired = false;
                    BillAmountRequired = false;
                }
            }
        }

        public string Fullname { get; set; }
        public bool FullNameRequired { get; private set; } = false;

        public string Address { get; set; }
        public bool AddressRequired { get; private set; } = false;

        public long MobileNumber { get; set; }
        public bool MobileNumberRequired { get; private set; } = false;

        public Guid BillNumber { get; set; }
        public bool BillNumberRequired { get; private set; } = false;

        public double BillAmount { get; set; }
        public bool BillAmountRequired { get; private set; } = false;
    }
}
