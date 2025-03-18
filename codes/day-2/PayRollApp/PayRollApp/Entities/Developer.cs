namespace PayRollApp.Entities
{
    public class Developer
    {
        #region Data Members
        readonly int id;
        string name;
        decimal basicPay;
        decimal daPay;
        decimal hraPay;
        decimal incentivePay;
        decimal totalPay;
        #endregion

        #region Constructors
        public Developer() { }

        public Developer(int id, string name, decimal basicPay, decimal daPay, decimal hraPay, decimal incentivePay)
        {
            this.id = id;
            //this.Name = name;
            this.name = name;
            this.basicPay = basicPay;
            this.daPay = daPay;
            this.hraPay = hraPay;
            this.incentivePay = incentivePay;
        }
        #endregion

        #region Properties
        public int Id => id;
        public decimal TotalPay { get => totalPay; }

        public string Name
        {
            set => name = value;
            get => name;
        }
        public decimal BasicPay
        {
            get => basicPay;
            set => basicPay = value;
        }
        public decimal DaPay
        {
            get => daPay;
            set => daPay = value;
        }
        public decimal HraPay
        {
            get => hraPay;
            set => hraPay = value;
        }
        public decimal IncentivePay
        {
            get => incentivePay;
            set => incentivePay = value;
        }
        #endregion

        #region Methods
        public void CalculateSalary()
        {
            totalPay = basicPay + daPay + hraPay + incentivePay;
        }
        #endregion
    }
}
