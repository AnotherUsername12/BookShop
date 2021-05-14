using System;
using System.Collections.Generic;
using BookShop.Books;

namespace BookShop.Human.Employee
{
    public class Consultant : Employee
    {
        public static List<Consultant> Objects = new List<Consultant>();
        public static string Position = "Консультант";

        //Constructors
        public Consultant(string N, int A, int H, int W, int S) : base(N, A, H, W, S)
        {
            Objects.Add(this);
        }


        //Methods
        public override void Work()
        {
            SayHello(Position);

            string r_book = Book.GetRandomBook();
            Console.WriteLine($"{Position} {Name}: Рекомендую вам книгу {r_book}.");
        }


        public void Work(Client Client, string Title)
        {
            SayHello(Position);
            bool is_exists = Book.IsExist(Title);

            if (is_exists == true)
            {
                Console.WriteLine($"{Position} {Name}: Нашёл эту книгу. Перенаправляю вас к кассиру.");
                Cashier.RandomWorker(Client, Title);
            }
            else
            {
                Console.WriteLine($"{Position} {Name}: К сожалению, такой книги у нас нет.");
            }
        }


        public static void RandomWorker(Client Client, string Title = null)
        {
            var rand = new Random();

            var w = Objects[rand.Next(0, Objects.Count)];
            w.Work(Client, Title);
        }
    }
}
