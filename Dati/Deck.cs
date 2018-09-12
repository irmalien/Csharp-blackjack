using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Dati
{
    class Deck
    {
        // Variable arrays for cards and suits
        public string[] Suits = {"H", "S", "D", "C"};
        public string[] Values = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

        public List<Card> Cards;

        // Constructor to create deck from all available cards
        public Deck()
        {
            Cards = new List<Card>();
            foreach (string suit in Suits)
            {
                foreach (string value in Values)
                {
                    Cards.Add(new Card(suit, value));
                }
            }
                
        }
        // Shuffle cards
        public void Shuffle()
        {
            Random rnd = new Random();
            Cards = Cards.OrderBy(c => rnd.Next()).ToList(); //sakārtot kārtis pēc random skaitļa
        }
        // Take first card from deck and remove from deck
        public Card GetCard()
        {
            Card card = Cards[0];
            Cards.Remove(card);
            return card;
        }
    }
}
