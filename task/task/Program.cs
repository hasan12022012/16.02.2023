using System;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Drink drink1 = new Drink { AlcoholPercent= 8.5 };
           Drink drink2 = new Drink(); 
           Dairy dairy1 = new Dairy();
           Dairy dairy2 = new Dairy();

            Store store= new Store();

            store.AddProduct(drink1);
            store.AddProduct(drink2);
            store.AddProduct(dairy1);
            store.AddProduct(dairy2);

            Console.WriteLine(store.AlcoholPercentLimit());

        }
    }
}
