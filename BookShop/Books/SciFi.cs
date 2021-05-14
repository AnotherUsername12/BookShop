using System;
using System.Collections.Generic;

namespace BookShop.Books
{
    public class SciFi : Book
    {
        public static List<SciFi> Objects = new List<SciFi>();

        //Constructors
        public SciFi(string T, string A, bool C) : base(T, A, C)
        {
            Objects.Add(this);
        }

        public SciFi(string T, string A, int Cst, int P, bool Cvr) : base(T, A, Cst, P, Cvr)
        {
            Objects.Add(this);
        }


        //Methods
        public static new string InStock()
        {
            string stock = "";

            foreach (SciFi item in SciFi.Objects)
            {
                stock += item.Title;
                stock += ", ";
            }

            return stock;
        }
    }
}
