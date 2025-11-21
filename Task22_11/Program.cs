namespace Task22_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Elave etmek isdeyiniz isci sayi: ");
            int countemployee=Convert.ToInt32(Console.ReadLine());
            Employee[] employees =new Employee [countemployee];
            for (int i = 0; i <countemployee; i++)
            {
                Console.WriteLine("Enter Name: ");
                string name= Console.ReadLine();
                Console.WriteLine("Enter SurName: ");
                string surname= Console.ReadLine();
                Console.WriteLine("Enter Birthday: ");
                string input = Console.ReadLine();
                DateTime birthday = DateTime.Parse(input);
                Console.WriteLine("Enter Salary: ");
                int salary= Convert.ToInt32(Console.ReadLine());
                employees[i]=new Employee(name,surname,birthday,salary);
            }

            Console.WriteLine("Date 1: ");
            DateTime datenum1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Date 2: ");
            DateTime datenum2 = DateTime.Parse(Console.ReadLine());
            int result=CountEmployees(employees, datenum1, datenum2);
            Console.WriteLine(result);
        }
        public static int CountEmployees(Employee[] employees, DateTime date1, DateTime date2)
        {
            int count = 0;

            foreach (Employee e in employees)
            {
                if (e.BirthDay > date1 && e.BirthDay < date2 && e.Salary > 2000)
                {
                    count++;
                }
            }

            return count;
        }

    }
}
