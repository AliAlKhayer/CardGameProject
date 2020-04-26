using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        public Card[] deck { get; set; }
        public int currentCard { get; set; }
        public const int numOfCards = 52;
        public Random randomNumber { get; set; }

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
        public void shuffle()
        {
            currentCard = 0;
            for (int i = 0; i < deck.Length; i++)
            {
                int secondNum = randomNumber.Next(numOfCards);
                Card placeholder = deck[i];
                deck[i] = deck[secondNum];
                deck[secondNum] = placeholder;
            }           
        }

        public Card Deal()
        {
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
            {
                return null;
            }
        }
    }
}