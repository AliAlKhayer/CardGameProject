using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        private Card[] deck { get; set; }
        private int currentCard { get; set; }
        private const int numOfCards = 52;
        private Random randomNumber { get; set; }

        public Deck()
        {
            string[] faces = { "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "jack", "queen", "king", "ace" };
            string[] suits = { "hearts", "diamonds", "spades", "clubs" };
            deck = new Card[numOfCards];
            currentCard = 0;
            randomNumber = new Random();

            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = new Card(faces[i % 11], suits[i / 13]);
            }
        }
    }
}