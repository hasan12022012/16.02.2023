using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace task
{
    internal class Store
    {
        public Product[] Products = new Product[0];
        
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }

        public int DairyProductCountLimit()
        {
            int count = 0;

            foreach (Product item in Products)
            {
                if (item is Dairy)
                    count++;
            }

            return count;
        }

        public double AlcoholPercentLimit()
        {
            Drink[] drinks = new Drink[0];

            foreach(Product item in Products) 
            {
                if (item is Drink)
                {
                    Drink drink= (Drink)item;
                    Array.Resize(ref drinks, drinks.Length + 1);
                    drinks[drinks.Length - 1] = drink;
                }
                    
            }

            double maxAlcoholPercent = 0;

            foreach (Drink item in drinks)
            {
                
                if (item.AlcoholPercent>maxAlcoholPercent)
                {
                    maxAlcoholPercent= item.AlcoholPercent;
                }
            }
            return maxAlcoholPercent;
            
        }
        public bool HasProductByNo(int no)
        {
            foreach(var item in Products)
            {
                if (item.No == no)
                {
                    return true;
                }
            }
            return false;
        }

        public Drink[] GetDrinkProducts()
        {
            Drink[] drinks= new Drink[0];
            foreach(var item in Products)
            {
                if(item is Drink)
                {
                    Drink drink= (Drink)item;
                    Array.Resize(ref drinks, drinks.Length + 1);
                    drinks[drinks.Length - 1] = drink;

                }
            }
            return drinks;
        }

        public Dairy[] GetDairyProducts()
        {
            Dairy[] dairies = new Dairy[0];
            foreach (var item in Products)
            {
                if (item is Dairy)
                {
                    Dairy dairy = (Dairy)item;
                    Array.Resize(ref dairies, dairies.Length + 1);
                    dairies[dairies.Length - 1] = dairy;

                }
            }
            return dairies;
        }
    }
}
