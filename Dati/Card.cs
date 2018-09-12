using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Dati
{
    class Card
    {
        public string Suit;
        public string Value;
        public Card(string suit, string value) //variable in function, constructor will pass on variables
        {
            //Large case for class variable, small case for variable passed by function
            Suit = suit;
            Value = value;
        }
        public int getPoints()
        {
            switch (Value)
            {
                case "A":
                    {
                        return 11;
                    }
                case "K":
                case "Q":
                case "J":
                    {
                        return 10;
                    }
                default:
                    return Int32.Parse(Value);
            }
        }
    }
}
