using System;
using System.Collections.Generic;

namespace BookShop.Books
{
    public class Fantasy : Book
    {
        public static List<Fantasy> Objects = new List<Fantasy>();

        //Constructors
        public Fantasy(string T, string A, bool C) : base(T, A, C)
        {
            Objects.Add(this);
        }

        public Fantasy(string T, string A, int Cst, int P, bool Cvr) : base(T, A, Cst, P, Cvr)
        {
            Objects.Add(this);
        }


        //Methods
        public static new string InStock()
        {
            string stock = "";

            foreach (Fantasy item in Fantasy.Objects)
            {
                stock += item.Title;
                stock += ", ";
            }

            return stock;
        }
    }
}
