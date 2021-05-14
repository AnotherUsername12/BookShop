using System.Collections.Generic;
using BookShop.Books;
using BookShop.Human;
using BookShop.Human.Employee;

namespace BookShop
{
    public class WorkDay
    {
        public static void Start()
        {
            Warehouseman.RandomWorker();

            foreach(Client person in Client.Objects)
            {
                person.Ask();
            }

            Warehouseman.RandomWorker();
        }
    }
}
