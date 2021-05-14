using System;
namespace BookShop
{
    public abstract class Person
    {
        public string Name { get; }
        public int Age { get; }
        public int Height { get; }
        public int Weight { get; }


        //Constructor
        public Person(string N, int A, int H, int W)
        {
            Name = N;
            Age = A;
            Height = H;
            Weight = W;
        }


        //Methods
        public void SayHello()
        {
            var rand = new Random();

            switch(rand.Next(1, 4))
            {
                case 2:
                    {
                        Console.WriteLine($"{Name}: Здравствуйте.");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"{Name}: Добрый день.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"{Name}: Привет.");
                        break;
                    }
            }
        }


        public void SayGoodbye()
        {
            var rand = new Random();

            switch (rand.Next(1, 3))
            {
                case 2:
                    {
                        Console.WriteLine($"{Name}: До свидания.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"{Name}: Пока.");
                        break;
                    }
            }
        }
    }
}
