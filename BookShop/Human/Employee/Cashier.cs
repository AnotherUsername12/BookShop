using System;
using System.Collections.Generic;
using BookShop.Books;

namespace BookShop.Human.Employee
{
    public class Cashier : Employee
    {
        public static List<Cashier> Objects = new List<Cashier>();
        public static string Position = "Кассир";

        //Constructors
        public Cashier(string N, int A, int H, int W, int S) : base(N, A, H, W, S)
        {
            Objects.Add(this);
        }


        //Methods
        public override void Work()
        {
            Console.WriteLine($"{Position} {Name}: На данный момент на кассе нет покупателей.");
        }


        public void Work(string Title, Client Client)
        {
            SayHello(Position);
            Console.WriteLine($"{Position} {Name}: Вы собираетесь купить книгу {Title}.");

            bool exists = Book.IsExist(Title);
            if (exists == true)
            {
                int Cost = Book.GetCost(Title);
                Console.WriteLine($"{Position} {Name}: Она стоит {Cost}.");

                if (Client.Money < Cost)
                {
                    Console.WriteLine($"{Position} {Name}: У вас недостаточно средств для покупки.");
                }
                else
                {
                    Client.Money -= Cost;
                    Book.DeleteBook(Title);
                    Console.WriteLine($"{Position} {Name}: Спасибо за покупку, {Client.Name}!");
                    Client.SayGoodbye();
                }
            }
            else
            {
                Console.WriteLine($"{Position} {Name}: К сожалению, такой книги у нас нет.");
            }
        }


        public static void RandomWorker()
        {
            var rand = new Random();

            var w = Objects[rand.Next(0, Objects.Count - 1)];
            w.Work();
        }


        public static void RandomWorker(Client Client, string Title = null)
        {
            var rand = new Random();

            var w = Objects[rand.Next(0, Objects.Count)];
            w.Work(Title, Client);
        }
    }
}
