using System;
using System.Collections.Generic;

namespace BookShop.Books
{
    public class Biography : Book
    {
        public static List<Biography> Objects = new List<Biography>();

        //Constructors
        public Biography(string T, string A, bool C) : base(T, A, C)
        {
            Objects.Add(this);
        }

        public Biography(string T, string A, int Cst, int P, bool Cvr) : base(T, A, Cst, P, Cvr)
        {
            Objects.Add(this);
            this.Cst = Cst;
        }

        public int Cst { get; }


        //Methods
        public static new string InStock()
        {
            string stock = "";

            foreach (Biography item in Biography.Objects)
            {
                stock += item.Title;
                stock += ", ";
            }

            return stock;
        }
    }
}
