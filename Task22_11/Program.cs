namespace Task22_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Elave etmek isdeyiniz isci sayi: ");
            //int countemployee=Convert.ToInt32(Console.ReadLine());
            //Employee[] employees =new Employee [countemployee];
            //for (int i = 0; i <countemployee; i++)
            //{
            //    Console.WriteLine("Enter Name: ");
            //    string name= Console.ReadLine();
            //    Console.WriteLine("Enter SurName: ");
            //    string surname= Console.ReadLine();
            //    Console.WriteLine("Enter Birthday: ");
            //    string input = Console.ReadLine();
            //    DateTime birthday = DateTime.Parse(input);
            //    Console.WriteLine("Enter Salary: ");
            //    int salary= Convert.ToInt32(Console.ReadLine());
            //    employees[i]=new Employee(name,surname,birthday,salary);
            //}

            //Console.WriteLine("Date 1: ");
            //DateTime datenum1 = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Date 2: ");
            //DateTime datenum2 = DateTime.Parse(Console.ReadLine());
            //int result=CountEmployees(employees, datenum1, datenum2);
            //Console.WriteLine(result);

            //Task2
            //Hotel hotel = new Hotel("Hilton", 0);
            //hotel.AddRoom(new Room("Single", 100, 1, true));
            //hotel.AddRoom(new Room("Double", 150, 2, true));
            //try
            //{
            //    hotel.Reserve(1);
            //    Console.WriteLine("Room reserved successfully.");
            //    hotel.Reserve(5); // Attempt to reserve a non-existing room
            //}
            //catch (NotAvailableException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (NotFoundException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Task3
            Console.WriteLine("Enter Bullet Capacity: ");
            int bulletcapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Bullet Count: ");
            int bulletcount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Fire Mode");
            FireMode firemode = (FireMode)Convert.ToInt32(Console.ReadLine());
            Weapon weapon = new Weapon(bulletcapacity, bulletcount, firemode);
            while(true)
            {
                Console.WriteLine("--Menu--");
                Console.WriteLine("0. ShowInfo");
                Console.WriteLine("1. Shoot");
                Console.WriteLine("2.Fire");
                Console.WriteLine("3. GetRemainBulletCount");
                Console.WriteLine("4. Reload");
                Console.WriteLine("5. ChangeFireMode");
                Console.WriteLine("6.Exit");
                Console.WriteLine("7.Redakte et");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine($"Bullet Capacity: {bulletcapacity}, Bullet Count: {bulletcount}, Fire Mode: {firemode}");
                        break;
                    case 1:
                        weapon.Shoot();
                        break;
                    case 2:
                        weapon.Fire();
                        break;
                    case 3:
                        weapon.GetRemainBulletCount();
                        break;
                    case 4:
                        weapon.Reload();
                        break;
                    case 5:
                        weapon.ChangeFireMode();
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        return;
                    case 7:
                        Console.WriteLine("--Redakte Menyusu--");
                        Console.WriteLine("T-Tutumu deyisir");
                        Console.WriteLine("S-Gulle sayi");
                        Console.WriteLine("D-Sifirlama saniyesi");
                        string option = Console.ReadLine();
                        switch (option)
                        {
                            case "T":
                                int newcapacity = Convert.ToInt32(Console.ReadLine());
                                weapon.BulletCapacity = newcapacity;
                                break;
                            case "S":
                                int newcount = Convert.ToInt32(Console.ReadLine());
                                weapon.BulletCount = newcount;
                                break;
                            case "D":
                                int newdischarge = Convert.ToInt32(Console.ReadLine());
                                weapon.DischargeTime = newdischarge;
                                break;
                            default:
                                Console.WriteLine("Invalid option.");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            
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
