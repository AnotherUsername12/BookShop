using System;
using BookShop.Human.Employee;
using BookShop.Human;
using BookShop.Books;
using System.Threading;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Books
            var book1 = new Biography("Napoleon", "Ponasenkov", true);
            var book2 = new Comix("Batman", "Marvel", false);
            var book3 = new Horror("It", "Steven King", true);
            var book4 = new Tutorial("C#", "Microsoft", false);
            var book5 = new Horror("Dagon", "Lovecraft", true);

            //Employees
            var vincent = new Warehouseman("Vicent", 39, 170, 60, 30000);
            var jules = new Consultant("Jules", 34, 179, 66, 29000);
            var butch = new Cashier("Butch", 28, 180, 58, 20000);

            //Clients
            var mr_green = new Client("MrGreen", 50, 190, 78, 30000);
            var mr_white = new Client("MrWhite", 50, 190, 78, 30000);
            var mr_brown = new Client("MrBrown", 50, 190, 78, 30000);
            var mr_pink = new Client("MrPink", 50, 190, 78, 30000);

            //Boss
            var boss = new Owner("Marsellus", 70, 169, 90);

            Console.WriteLine("===============");
            WorkDay.Start();
        }
    }
}
