using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    internal abstract class Product
    {
        public Product()
        {
            Count++;
            _no = Count;
        }

        int _no;
        public string Name;
        public double Price;
        public static int Count;

        public  int No
        {
            get { return _no; }
            
        }

        

    }
}
