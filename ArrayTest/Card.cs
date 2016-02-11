using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Card

    {
        private String name;
        private int cost;
        
        public Card()
        { }
        
        public Card(String str, int num)
        {
            this.name = str;
            this.cost = num;

        }

        public void getStats()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Cost);
        }

        public String Name
        {
            get
            {
                return this.name;
            }
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
