using System;
using BookShop.Books;
using System.Collections.Generic;

namespace BookShop.Human.Employee
{
    public class Warehouseman : Employee
    {
        public static List<Warehouseman> Objects = new List<Warehouseman>();
        public static string Position = "Складовщик";

        //Constructors
        public Warehouseman(string N, int A, int H, int W, int S) : base(N, A, H, W, S)
        {
            Objects.Add(this);
        }


        //Methods
        public override void Work()
        {
            string in_stock = Book.InStock();
            Console.WriteLine($"{Position} {Name}: Проверяю имеющиеся книги.");

            if (in_stock != null)
            {
                Console.WriteLine($"{Position} {Name}: Нашёл {in_stock}.");
            }
            else
            {
                Console.WriteLine($"{Position} {Name} :Не нашел книги.");
            }
            
        }


        public static void RandomWorker()
        {
            var rand = new Random();

            var w = Objects[rand.Next(0, Objects.Count)];
            w.Work();
        }
    }
}
