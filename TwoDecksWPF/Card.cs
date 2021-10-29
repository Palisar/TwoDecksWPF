using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDecksWPF
{
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public string Name { get {return $"{Value} of {Suit}"; } }
        public Card(Values value, Suits suit)
        {
            Suit = suit;
            Value = value;
        }
        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
