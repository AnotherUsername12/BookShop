using System;
using System.Collections.Generic;

namespace BookShop.Books
{
    public class Tutorial : Book
    {
        public static List<Tutorial> Objects = new List<Tutorial>();

        //Constructors
        public Tutorial(string T, string A, bool C) : base(T, A, C)
        {
            Objects.Add(this);
        }

        public Tutorial(string T, string A, int Cst, int P, bool Cvr) : base(T, A, Cst, P, Cvr)
        {
            Objects.Add(this);
        }


        //Methods
        public static new string InStock()
        {
            string stock = "";

            foreach (Tutorial item in Tutorial.Objects)
            {
                stock += item.Title;
                stock += ", ";
            }

            return stock;
        }
    }
}
