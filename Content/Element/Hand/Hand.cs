using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFCPoker.Content.Element.Hand
{
    class Hand : ElementBase
    {
        private List<Card.Card> Cards;
        private short MaxCards; 
        public short NumCards { get; }

        public Hand(in short maxCards) //where to get max cards from? Settings? Fantasyland?
        {
            MaxCards = maxCards;
        }

        public void AddCard(in Card.Card card)
        {
            if(Cards.Count < MaxCards)
            {
                Cards.Add(card);
            }
        }

        public void RemoveCard(in Card.Card card)
        {
            if(Cards.Count > 0)
            {
                Cards.Remove(card);
            }
        }

    }
}
