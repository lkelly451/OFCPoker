using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFCPoker.Content.Element.Card
{
    class Card : ElementBase
    {
        public short Value { get; }

        public Card(short value)
        {
            Value = value;
        }

        public void Lay(in Card card, in Street.Street street)
        {
            street.AddCard(card);
        }

        public void ReturnToDeck(in Card card, ref Deck.Deck deck)
        {
            deck.AddCard(card);
        }
    }
}
