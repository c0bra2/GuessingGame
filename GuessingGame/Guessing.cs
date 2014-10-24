using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessingGame
{
    /// <summary>
    /// This class is used to pick a random number, and then allow one or two players to guess what it is.
    /// </summary>
    class Guessing
    {
        bool twoplayers;
        bool player1high; //used to store whether player2 guessed too high.
        bool player2correct;
        bool player1correct;
        int player1Score;
        int player2Score;
        int player2guess;
        int upper;
        int lower;
        Random rnd = new Random();
        int target;
        
        public Guessing(bool arg){          // the bool argument determines if 1 or 2 players will be entering the game
            target = rnd.Next(0, 100); //determine a random number between 0 and 100 to use in the game.
            twoplayers = arg;
            player1Score = 0;
            player2Score = 0;
            player2guess = 50;
            player2correct = false;
            player1correct = false;
            player1high = false;
            upper = 100;
            lower = 0;

            if (arg)
            {
                playerTwoGuess();
            }
        }

        public bool isPlayerHigh()
        { 
           return player1high;
        }
        public void playerTwoGuess(int playersGuess)
        {
            if (playersGuess == target)
                player1correct = true;
            else if (playersGuess > target)
                player1high = true;
            else
                player1high = false;
            
            player1Score++;
        }
        public int getTarget()
        {
            return target;
        }
        /// <summary>
        /// AI algorithm for guessing game
        /// </summary>
        private void playerTwoGuess(){
            if (player2guess < target) // if the guess is too low, pick a midpoint between the previous guess and upper limit.
            {
                lower = player2guess; // we know the guess must be greater than this lower limit
                player2guess = (player2guess + upper) / 2;
            }
            else if (player2guess > target)
            {
                upper = player2guess; // we now know the guess must be lower than this upper limit
                player2guess = (lower + player2guess) / 2;
            }
            else
                player2correct = true;
            
            player2Score++;
        }

        public string playerTwoMove()
        {
            string res = player2guess.ToString();
            playerTwoGuess();
            return res;
        }

        public int whoWon()
        {
            if (player1correct)
                return 1;
            else if (player2correct)
                return 2;
            else
                return 0;
        }

        public int getP1Guesses()
        {
            return player1Score;
        }

        public int getP2Guesses()
        {
            return player2Score;
        }
    }
}
