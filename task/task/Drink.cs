using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    internal class Drink:Product
    {
        double _alcoholPercent;

        public double AlcoholPercent
        {
            get { return _alcoholPercent; }
            set 
            {
                if (value <= 40)
                {
                    _alcoholPercent = value;
                }
                    
            }
        }

    }
}
