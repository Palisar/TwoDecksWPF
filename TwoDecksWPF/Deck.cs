using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDecksWPF
{
    class Deck : ObservableCollection<Card>
    {
        private static Random random = new();
        public Deck()
        {
            Reset();
        }
        public void Reset()
        {
            Clear();
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    Add(new Card((Values)value, (Suits)suit));
                }
            }
        }

        public Card Deal(int index)
        {
            Card card = base[index];
            RemoveAt(index);
            return card;
        }
        public void Shuffle()
        {
            Card shuffle;
            List<Card> copy = new List<Card>(this);
            foreach (Card card in copy)
            {
                int index = random.Next(copy.Count);
                shuffle = base[index];
                RemoveAt(index);
                Add(shuffle);
            }
        }
        public void Sort()
        {
            List<Card> sortedCards = new List<Card>(this);
            sortedCards.Sort(new CardComparedByValue());
            Clear();
            foreach (Card card in sortedCards)
            {
                Add(card);
            }
        }
    }
}    