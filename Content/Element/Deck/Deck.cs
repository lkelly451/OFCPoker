using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFCPoker.Content.Element.Deck
{
    class Deck : ElementBase
    {
        private List<Card.Card> PlayDeck;
        private short MaxNumCards;
        public short NumCards { get; }

        public Deck(List<Card.Card> deck, short maxNumCards) 
        {
            PlayDeck = deck;
            MaxNumCards = maxNumCards;

            Shuffle(ref PlayDeck);
        }


        public void Shuffle(ref List<Card.Card> deck)
        {
            Random rand = new Random();
            
            for(int currentCard = deck.Count-1; currentCard > 0; --currentCard)
            {
                int swapIndex = rand.Next(currentCard + 1);
                Card.Card tempCard = deck[currentCard];
                deck[currentCard] = deck[swapIndex];
                deck[swapIndex] = tempCard;
            }
        }

        public void DrawCards(ref Hand.Hand hand, in short numToDraw)
        {
            if(PlayDeck.Count < numToDraw)
            {
                //message UI
                return;
            }
            for(short currentDraw = 0; currentDraw < numToDraw; ++currentDraw)
            {
                hand.AddCard(PlayDeck[0]);

                PlayDeck.RemoveAt(0);
            }              
            
        }

        public void AddCard(in Card.Card card)
        {
            if(PlayDeck.Count < MaxNumCards)
            {
                PlayDeck.Add(card);
            }
            
        }



    }
}
