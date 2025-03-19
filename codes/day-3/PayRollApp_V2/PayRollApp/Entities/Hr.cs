namespace PayRollApp.Entities
{
    public class Hr : Employee
    {
        #region Data Members        
        decimal gratuityPay;
        #endregion

        #region Constructors
        public Hr() { }

        public Hr(int id, string name, decimal basicPay, decimal daPay, decimal hraPay, decimal gratuityPay) : base(id, name, basicPay, daPay, hraPay)
        {
            this.gratuityPay = gratuityPay;
        }
        #endregion

        #region Properties
        public decimal GratuityPay
        {
            get => gratuityPay;
            set => gratuityPay = value;
        }
        #endregion

        #region Methods
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            TotalPay += gratuityPay;
        }
        #endregion
    }
}
