using static EmployeePayTypeEnum;
public class SalesPersonal: Employee
    {
        public int SalesNumber { get; set; }
        public SalesPersonal() { }
        public SalesPersonal(string fullName, int age, int empId, float currPay, string ssn, int numbOfOpts) :
            base (fullName,age, empId,currPay,ssn, EmployeePayTypeEnumm.Salaried)
        { 
            SalesNumber = numbOfOpts;
        }
        public override void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if(SalesNumber > 0 && SalesNumber <=100)
                salesBonus = 10;
            else
            {
                if (SalesNumber > 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
           base.GiveBonus(amount * salesBonus);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("SalesNumbers: {0}", SalesNumber);
        }
    }