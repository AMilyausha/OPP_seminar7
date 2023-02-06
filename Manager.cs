using static EmployeePayTypeEnum;
public class Manager:Employee
    {
        public int StockOptions { get; set; }
        public Manager() { }
        public Manager(string fullName, int age, int empId, float currPay, string ssn, int numbOfOpts):
            base(fullName,age, empId,currPay,ssn, EmployeePayTypeEnumm.Salaried)
        {
            StockOptions = numbOfOpts;
        }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions+=r.Next(500);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("StockOptions: {0}", StockOptions);
        }
    }