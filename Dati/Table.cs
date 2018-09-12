using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Dati
{
    public class Table
    {
        private Deck deck;
        private Dealer dealer;
        private Player player;

        public Table()
        {

        }
        // 1. void StartNewGame()
        public void StartNewGame()
        {
            // 1.1. Take new deck of cards
            deck = new Deck();
            dealer = new Dealer();
            player = new Player();
            // 1.2. shuffle cards
            deck.Shuffle();
            // 1.3 player gets two cards 
            player.GiveCard(deck.GetCard());
            player.GiveCard(deck.GetCard());
            // 1.4 dealer gets two cards
            dealer.GiveCard(deck.GetCard());
            dealer.GiveCard(deck.GetCard());
        }
        //Player
        // 4.1. give cards to player as long as he needs
        public void PlayerTurn()
        {
            while (player.NeedCard())
            {
                player.GiveCard(deck.GetCard());
            }
        }

        //Dealer
        // 4.1. give cards to dealer as long as he neccesery
        public void DealerTurn()
        {
            while (dealer.NeedCard())
            {
                dealer.GiveCard(deck.GetCard());
            }
        }

        // 3. void ShowResults()
        // 3.1 Display results who won

        public void ShowResults()
        {
            int playerPoints = player.CountPoints();
            int dealerPoints = dealer.CountPoints();
            Console.WriteLine("\n");
            Console.WriteLine("Player points: " + playerPoints);
            Console.WriteLine("Dealer points: " + dealerPoints);

            if (playerPoints > 21)
                Console.WriteLine("You lost!");
            else if (dealerPoints > 21)
                Console.WriteLine("You won!");
            else if (dealerPoints == playerPoints)
                Console.WriteLine("Draw!");
            else if (playerPoints > dealerPoints)
                Console.WriteLine("You lost!");
            else
                Console.WriteLine("You lost!");

        }

        // 2. bool PlayAgain()
        // 2.1. Ask if player wants to play another game
        public bool PlayAgain()
        {
            Console.WriteLine("Do you want to play again (y/n)? ");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y")
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
