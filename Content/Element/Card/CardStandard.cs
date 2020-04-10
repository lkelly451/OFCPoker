using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFCPoker.Content.Element.Card
{
    class CardStandard : Card
    {
        SuitStandard Suit;
        CardStandard(in short value, SuitStandard suit) : base(value) 
        {
            Suit = suit;
        }



    }
      
}
