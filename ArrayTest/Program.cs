using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Card testCard = new Card("Testcard", 10);
            Console.WriteLine(testCard.getName());
            Console.WriteLine(testCard.Cost);
            Console.Read();
        }
    }
}
