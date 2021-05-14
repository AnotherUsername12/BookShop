using System;
using System.Collections.Generic;

namespace BookShop.Books
{
    public abstract class Book
    {
        public string Title { get; }
        public string Author { get; }
        public int Cost { get; }
        public int Pages { get; }
        public bool Cover { get; }

        public static Dictionary<string, int> BooksCosts = new Dictionary<string, int>();
        public static List<string> BooksTitles = new List<string>();

        //Constructors
        public Book(string T, string A, int Cst, int P, bool Cvr)
        {
            Title = T;
            Author = A;
            Cost = Cst;
            Pages = P;
            Cover = Cvr;

            BooksCosts.Add(this.Title, this.Cost);
            BooksTitles.Add(this.Title);
        }


        public Book(string T, string A, bool C)
        {
            var rand = new Random();

            Title = T;
            Author = A;
            Cover = C;

            Cost = rand.Next(1000, 3000);
            Pages = rand.Next(150, 550);

            BooksCosts.Add(this.Title, this.Cost);
            BooksTitles.Add(this.Title);
        }


        //Methods
        public static string InStock()
        {
            return string.Join(", ", BooksCosts.Keys);
        }


        public static bool IsExist(string Title)
        {
            foreach (KeyValuePair<string, int> keyValue in BooksCosts)
            {
                if (keyValue.Key == Title)
                {
                    return true;
                }
            }
            return false;
        }


        public static int GetCost(string Title)
        {
            foreach (KeyValuePair<string, int> keyValue in BooksCosts)
            {
                if (keyValue.Key == Title)
                {
                    return keyValue.Value;
                }
            }
            return 0;
        }


        public static string GetRandomBook()
        {
            var rand = new Random();
            return BooksTitles[rand.Next(0, BooksTitles.Count)];
        }


        public static void DeleteBook(string Title)
        {
            BooksCosts.Remove(Title);
            BooksTitles.Remove(Title);
        }
    }
}
