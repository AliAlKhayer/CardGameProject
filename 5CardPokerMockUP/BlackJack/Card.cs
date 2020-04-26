using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        public string value { get; set; }
        public string suit { get; set; }

        public Card(string cardFace, string cardSuit)
        {
            value = cardFace;
            suit = cardSuit;          
        }

        public override string ToString()
        {
            return $"{value} of {suit}";
        }
    }
}
