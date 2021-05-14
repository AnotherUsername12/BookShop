using System;
using System.Collections.Generic;

namespace BookShop.Books
{
    public class Comix : Book
    {
        public static List<Comix> Objects = new List<Comix>();

        //Constructors
        public Comix(string T, string A, bool C) : base(T, A, C)
        {
            Objects.Add(this);
        }

        public Comix(string T, string A, int Cst, int P, bool Cvr) : base(T, A, Cst, P, Cvr)
        {
            Objects.Add(this);
        }


        //Methods
        public static new string InStock()
        {
            string stock = "";

            foreach (Comix item in Comix.Objects)
            {
                stock += item.Title;
                stock += ", ";
            }

            return stock;
        }
    }
}
