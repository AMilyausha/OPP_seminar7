using static EmployeePayTypeEnum;
    public class Employee{
        private string _empName;
        private int _empId;
        private float _currPay;
        private int _age;
        private string _empSSN;
        private EmployeePayTypeEnumm _payType;

        public string SocialSecurityNumber
        {
           get { return _empSSN; }
           private set { _empSSN = value; }
        }
        public EmployeePayTypeEnumm PayType
        {
            get { return _payType; }
            set { _payType = value; }   
        }

        public Employee() { }
       
        public Employee(string name, int id, float pay,string empSsn)
            :this (name,id,0, pay, empSsn, EmployeePayTypeEnumm.Salaried) { }
        public Employee(string name, int id, int age, float pay,string snn,EmployeePayTypeEnumm payTypeEnum )
        {
            Pay=pay;
            Name=name;
            Id=id;
            Age=age;
            SocialSecurityNumber=snn;
            PayType = payTypeEnum;

        }
        // свойства! полей
        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    _empName = value;
                }
            }
        }

        public int Id
        {
            get { return _empId; }
            set { _empId = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public float Pay { get { return _currPay; } set { _currPay = value; } }
        public virtual void GiveBonus(float amount)
        {
            switch (PayType)
            {
                case EmployeePayTypeEnumm.Commission:
                    Pay += .10f * amount;
                    break;
                case EmployeePayTypeEnumm.Hourly:
                    Pay += 40f * amount / 2080F;
                    break;
                case EmployeePayTypeEnumm.Salaried:
                    Pay += amount;
                    break;
                default:
                    Pay += 0;
                    break;
            }
        }
        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("SSN: {0}", SocialSecurityNumber);
           
        }

    }