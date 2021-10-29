
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDecksWPF
{
    class CardComparedByValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            //This Method Will compare the cards first using the Suit and after that by the value
            if (x.Suit < y.Suit)
                return -1;
            if (x.Suit > y.Suit)
                return 1;
            if (x.Value > y.Value)
                return -1;
            if (x.Value < y.Value)
                return 1;
            return 0;
        }
    }
}
