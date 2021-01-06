using System;
using System.Collections.Generic;
using System.Linq;

namespace AllCardsOnDeckv4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generating a Random number
            var randomNumberGenerator = new Random();
            var suits = new List<string>() { "Hearts", "Clubs", "Spades", "Diamonds" };
            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            var deck = new List<string>() { };

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    deck.Add(rank + " of " + suit);
                }
            };
            var n = deck.Count();

            for (var index = n - 1; index >= 0; index--)
            {
                var randomNumber = randomNumberGenerator.Next(52);
                var swapCards = deck[index];

                deck[index] = deck[randomNumber];
                deck[randomNumber] = swapCards;
            };
            // foreach (var card in deck)
            // {
            // Console.WriteLine(card);
            // };
            Console.WriteLine(deck[0]);
            Console.WriteLine(deck[1]);

            //deck[rightIndex] = rightCard;
            //deck[leftIndex] = leftCard;

        }
    }
}