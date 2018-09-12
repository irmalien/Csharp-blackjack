using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Dati
{
    class Player
    {
        //List of cards that player have
        public List<Card> Cards;
        
        //Constructor without variables
        public Player()
        {
            Cards = new List<Card>();
        }


        // Count point of all player cards
        public int CountPoints()
        {
            int points = 0;
            int aceCount = 0;
            foreach (Card c in Cards)
            {
                points += c.getPoints();
                //if aces, them add count
                if (c.Value == "A")
                {
                    aceCount++;
                }
            }

            // Ace treatment - if points above 21 and have ace, then remove 10 points, while below 21 or out of aces.
            while (points > 21 && aceCount > 0)
            {
                points -= 10; //remove 10 points
                aceCount--; //remove A from player hand
            }

            return points;

        }



        // 4. void giveCard(Card card) - add card to players hand
        public virtual void GiveCard(Card card)
        {
            Cards.Add(card);
            Console.WriteLine("Player got " + card.Suit + card.Value);
            Console.WriteLine("Points = " + CountPoints());
        } 
        
        //virtual means that lower class can edit this method.
        //bool needCard() - do you need more cards?
        public virtual bool NeedCard()
        {
            if (CountPoints() > 21)
            {
                return false;
            }
            Console.Write("Do you neeed another card (y/n)?");
            string atbilde = Console.ReadLine();

            if (atbilde.ToLower() == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
