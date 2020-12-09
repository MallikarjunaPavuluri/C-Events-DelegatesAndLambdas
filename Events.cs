using System;
namespace Hotel
{
    public  delegate void MyAction<T>(Object Source,EventArgs e, T a, T b);
    public delegate int Price(int t);
    public delegate void Cash(int t);
    public class Room
    {
        public static event MyAction<String> CustomerAction;
        public static event Cash Paid; 
        public static int Cost(int days)
        {
            Paid.Invoke(days);
            return days * 50;
        }
        public static int Discount(int days)
        {

            return days * 10;
        }
        public  static void CheckIn(String s1, String s2)
        {
            Room r = new Room();
            CustomerAction(r, EventArgs.Empty,s1,s2);
            Console.WriteLine($"Check in Name of Two Persons-{s1} And {s2}");
        }
        public static void CheckOut(String s1, String s2)
        {
            Console.WriteLine($"Check Out Name of Two Persons-{s1} And {s2}");
        }
        public static void Welcome(String s1, String s2)
        {
            Console.WriteLine($"Welcome {s1} And {s2}  To AIR Hotels");
        }
        public static void Great(String s1, String s2)
        {
            Console.WriteLine($"Great to have {s1} And {s2}  In AIR Hotels");
        }

    }
    public class Program
    {
         public static void Cashier(int n)
        {
            Console.WriteLine($"Hey Cashier {n} days Cash Method Invoked check once");
        }
        public static void Manger(int n)
        {
            Console.WriteLine($"Hey Manger {n} days Cash Method Invoked check once");
        }
        public static void Staff(object souce, EventArgs e, String s1,String s2)
        {
            Console.WriteLine($"Hey {s1} And {s2} at checkin or Check Out Process Look once");
        }
        public static void RoomService(object souce, EventArgs e, String s1, String s2)
        {
            Console.WriteLine($"Hey Room Service {s1} And {s2} at checkin or Check Out Process Look once");
        }

        public static void Main(String[] args)
        {
            Program p = new Program();
            Room.Paid += Cashier;
            Room.Paid += Manger;
            int cost = Room.Cost(10);
            Console.WriteLine($"Cost-{cost}");
            Room.Paid += Cashier;
            cost = Room.Cost(20);
            Console.WriteLine($"Cost-{cost}");
            Room.Paid -= Cashier;
            cost = Room.Cost(30);
            Console.WriteLine($"Cost-{cost}");
            Room r = new Room();
            Room.CustomerAction += Program.Staff;
            Room.CustomerAction += Program.RoomService;
            Room.CheckIn("Ram", "Arjun");
            
        }

    }
}
