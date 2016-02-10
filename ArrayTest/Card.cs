using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Card

    {
        private String Name;
        private int cost;
        
        public Card()
        { }
        
        public Card(String str, int num)
        {
            this.Name = str;
            this.cost = num;

        }

        public String getName()
        {
            return this.Name;
        }

        public int Cost
        {
            get
            {
                return this.cost;
            }
        }
    }
}
