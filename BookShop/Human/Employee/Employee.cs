using System;
using BookShop.Books;

namespace BookShop.Human.Employee
{
    public abstract class Employee : Person
    {
        public int Salary { get; }

        //Constructors
        public Employee(string N, int A, int H, int W, int S) : base(N, A, H, W)
        {
            Salary = S;
        }


        //Methods
        public abstract void Work();


        public void SayHello(string Position)
        {
            var rand = new Random();

            switch (rand.Next(1, 4))
            {
                case 2:
                    {
                        Console.WriteLine($"{Position} {Name}: Здравствуйте.");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"{Position} {Name}: Добрый день.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"{Position} {Name}: Привет.");
                        break;
                    }
            }
        }


        public void SayGoodbye(string Position)
        {
            var rand = new Random();

            switch (rand.Next(1, 3))
            {
                case 2:
                    {
                        Console.WriteLine($"{Position} {Name}: До свидания.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"{Position} {Name}: Пока.");
                        break;
                    }
            }
        }
    }
}
