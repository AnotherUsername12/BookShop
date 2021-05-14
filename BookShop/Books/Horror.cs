using System;
using System.Collections.Generic;

namespace BookShop.Books
{
    public class Horror : Book
    {
        public static List<Horror> Objects = new List<Horror>();

        //Constructors
        public Horror(string T, string A, bool C) : base(T, A, C)
        {
            Objects.Add(this);
        }

        public Horror(string T, string A, int Cst, int P, bool Cvr) : base(T, A, Cst, P, Cvr)
        {
            Objects.Add(this);
        }


        //Methods
        public static new string InStock()
        {
            string stock = "";

            foreach(Horror item in Horror.Objects)
            {
                stock += item.Title;
                stock += ", ";
            }

            return stock;
        }
    }
}
