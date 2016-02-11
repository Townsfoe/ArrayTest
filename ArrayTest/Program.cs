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
            Card b2 = new Card("B", 2);
            Card c3 = new Card("C", 3);
            Card d4 = new Card("D", 4);
            List<Card> cards = new List<Card>();
            cards.Add(testCard);
            Dictionary<String, Card> cardlist = new Dictionary<string, Card>();
            cardlist.Add("testCard", testCard);
            cardlist.Add("b2", b2);
            cardlist.Add("c3", c3);
            cardlist.Add("d4", d4);
            String inputCard = Console.ReadLine();
            if (cardlist.ContainsKey(inputCard))
            {
                cardlist[inputCard].getStats();
            }
            else
            {
                Console.WriteLine("That isn't a card");
            }
            Console.ReadLine();
        }
    }
}
