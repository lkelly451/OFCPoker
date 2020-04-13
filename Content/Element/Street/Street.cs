using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFCPoker.Content.Element.Street
{
    class Street : ElementBase
    {
        private List<Card.Card> CurrentCards;
        private short MaxCards;
        public short Score { get; }

        public Street(List<Card.Card> currentCards, short maxCards) 
        {
            CurrentCards = currentCards;
            MaxCards = maxCards;
        }

        public void AddCard(in Card.Card card)
        {
            if(CurrentCards.Count < MaxCards)
            {
                CurrentCards.Add(card);
                CurrentCards.Sort((card1, card2) => card1.Value.CompareTo(card2.Value));
            }
        }

        public void RemoveCard(in Card.Card card)
        {
            if(CurrentCards.Count > 0)
            {
                CurrentCards.Remove(card);
            }
            
        }


    }
}
