namespace PayRollApp.Entities
{
    public class Developer : Employee
    {
        #region Data Members        
        decimal incentivePay;
        #endregion

        #region Constructors
        public Developer() { }

        public Developer(int id, string name, decimal basicPay, decimal daPay, decimal hraPay, decimal incentivePay) : base(id, name, basicPay, daPay, hraPay)
        {
            this.incentivePay = incentivePay;
        }
        #endregion

        #region Properties
        public decimal IncentivePay
        {
            get => incentivePay;
            set => incentivePay = value;
        }
        #endregion

        #region Methods
        public void CalculateSalary()
        {
            base.CalculateSalary();
            TotalPay += incentivePay;
        }
        #endregion
    }
}
