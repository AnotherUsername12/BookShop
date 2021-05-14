using System;
using System.Collections.Generic;

namespace BookShop.Books
{
    public class History : Book
    {
        public static List<History> Objects = new List<History>();

        //Constructors
        public History(string T, string A, bool C) : base(T, A, C)
        {
            Objects.Add(this);
        }

        public History(string T, string A, int Cst, int P, bool Cvr) : base(T, A, Cst, P, Cvr)
        {
            Objects.Add(this);
        }


        //Methods
        public static new string InStock()
        {
            string stock = "";

            foreach (History item in History.Objects)
            {
                stock += item.Title;
                stock += ", ";
            }

            return stock;
        }
    }
}
