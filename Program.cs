Manager manager =new Manager("Kolya",50,92,100000,"12-12-12",37);
manager.GiveBonus(300);
Console.WriteLine("Manager");
manager.DisplayStats();
Console.WriteLine("**********************");
SalesPersonal sales = new SalesPersonal("Ivan",23,35,80000,"12-13-12",31);
sales.GiveBonus(100);
Console.WriteLine("SalesPersonal");
sales.DisplayStats();
