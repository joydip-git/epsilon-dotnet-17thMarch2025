namespace PayRollApp.Entities
{
    public class Employee
    {
        #region Data Members
        readonly int id;
        string name = "";
        decimal basicPay;
        decimal daPay;
        decimal hraPay;
        decimal totalPay;
        #endregion

        #region Constructors
        public Employee() { }

        public Employee(int id, string name, decimal basicPay, decimal daPay, decimal hraPay)
        {
            this.id = id;
            this.name = name;
            this.basicPay = basicPay;
            this.daPay = daPay;
            this.hraPay = hraPay;
        }
        #endregion

        #region Properties
        public int Id => id;
        public decimal TotalPay 
        {
            protected set => totalPay = value;
            get => totalPay; 
        }

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
        #endregion

        #region Methods
        public virtual void CalculateSalary()
        {
            totalPay = basicPay + daPay + hraPay;
        }
        public virtual string GetInformation()
        {
            return $"Name={name}, Salary={totalPay}";
        }
        #endregion
    }
}
