using System;

namespace HighOrLow
{
    public class Card
    {
        public int drawCard()
        {
            string[] suits = { "spades", "hearts", "diamonds", "clubs" };
            Random cardSuit = new Random();
            Random drawCardValue = new Random();
            int suitValue = cardSuit.Next(0, 3);
            int cardValue = drawCardValue.Next(2, 14);
            return cardValue;
        }

    }

        public class Game : Card
        {
           public void playGame()
        { 
            
            var card = new Card();
            var drawnCard = card.drawCard();
            var playedCard = card.drawCard();

            Console.WriteLine("{0} + {1}", playedCard);
            Console.WriteLine("{0} + {1}", drawnCard);

            if (playedCard == drawnCard)
            {
                Console.WriteLine("Cards cannot match!");
                drawnCard = card.drawCard();
            }
            else
            {
                Console.WriteLine("Game works kinda!");
            }

            //string drawnCardValue = drawnCard.Substring(0, 1);
            //tring playedCardValue = playedCard.Substring(0, 1);

        }

        /*public class Guess
        {
            public void gameMove(string input)
            {
                if (input.ToLower != "high" || "low")
                {
                    Console.WriteLine("Please enter 'high' or 'low'.");
                }
            }
        }*/

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess high or low: ");
            Console.ReadLine();
            var newGame = new Game();
            newGame.playGame();
        }
    }
}
