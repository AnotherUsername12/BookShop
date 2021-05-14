using System;
using System.Collections.Generic;

namespace BookShop.Books
{
    public class Classic : Book
    {
        public static List<Classic> Objects = new List<Classic>();

        //Constructors
        public Classic(string T, string A, bool C) : base(T, A, C)
        {
            Objects.Add(this);
        }

        public Classic(string T, string A, int Cst, int P, bool Cvr) : base(T, A, Cst, P, Cvr)
        {
            Objects.Add(this);
        }


        //Methods
        public static new string InStock()
        {
            string stock = "";

            foreach (Classic item in Classic.Objects)
            {
                stock += item.Title;
                stock += ", ";
            }

            return stock;
        }
    }
}
