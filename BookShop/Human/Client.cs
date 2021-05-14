using System;
using System.Collections.Generic;
using BookShop.Books;
using BookShop.Human.Employee;

namespace BookShop.Human
{
    public class Client : Person
    {
        public int Money { get; set; }
        public static List<Client> Objects = new List<Client>();


        //Constructors
        public Client(string N, int A, int H, int W, int M) : base(N, A, H, W)
        {
            Money = M;
            Objects.Add(this);
        }


        //Methods
        public void Ask()
        {
            SayHello();

            string r_book = Book.GetRandomBook();
            Console.WriteLine($"{Name}: У вас есть книга {r_book}?");

            Consultant.RandomWorker(this, r_book);
        }


        public void Ask(string Title)
        {
            Console.WriteLine($"{Name}: У вас есть книга {Title}?");
            Consultant.RandomWorker(this, Title);
        }


        public static void RandomClient()
        {
            var rand = new Random();

            var c = Objects[rand.Next(0, Objects.Count)];
            c.Ask();
        }
    }
}
