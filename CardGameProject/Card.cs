using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameProject
{
    class Card
    {
        public int suit;
        public int number;
        public Card next;

        public Card(int s, int n)
        {
            suit = s;
            number = n;
            next = null;
        }
        public string getCardName(Card c)
        {
            string s = c.number.ToString();
            switch (c.suit)
            {
                case 0:
                    s += "Clubs";
                    break;
                case 1:
                    s += "Hearts";
                    break;
                case 2:
                    s += "Spades";
                    break;
                case 3:
                    s += "Diamonds";
                    break;
            }
            return s;
        }
        public string printCard()
        {
            //Console use only
            string s = "";
            switch (number)
            {
                case 11:
                    s += "Jack";
                    break;
                case 1:
                    s += "Ace";
                    break;
                case 12:
                    s += "Queen";
                    break;
                case 13:
                    s += "King";
                    break;
                default:
                    s += number;
                    break;
            }
            switch (suit)
            {
                case 0:
                    s += " Clubs";
                    break;
                case 1:
                    s += " Hearts";
                    break;
                case 2:
                    s += " Spades";
                    break;
                case 3:
                    s += " Diamonds";
                    break;
            }
            s += "\r\n";
            return s;
        }
    }
}
