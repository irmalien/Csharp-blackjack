using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Dati
{
    class Dealer: Player
    {
        //Override calls methods that can be modified
        public override void GiveCard(Card card)
        {
            Cards.Add(card);
        }

        public override bool NeedCard()
        {
            // If less than 17 points, request new card
            return CountPoints() < 17;
         }
    }
}
