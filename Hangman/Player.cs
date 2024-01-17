using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public class Player
    {
        public int lives;

        List<char>? charList { get; set; }
        List<char> correctGuesses = new List<char>();
        List<char> wrongGuesses = new List<char>();

        public Player(int numberOfLives) { 
            lives = numberOfLives;
        }

        public int getlives()
        {
            return lives;
        }

        public void setlives(int numberOfLives) {  lives = numberOfLives; }
        public List<char> getcorrectGuesses() {  return correctGuesses; }
        public void setCorrectGuesses(char c)
        {
            correctGuesses.Add(c);
        }

        public List<char> getWrongGuesses() { return wrongGuesses; }
        public void setWrongGuesses(char c)
        {
            wrongGuesses.Add(c);
        }

        public void displayWrongGuesses(char c)
        {
            setWrongGuesses(c);
            string guesses = string.Join(", ", getWrongGuesses());
            Console.WriteLine(guesses);
        }

    }
}
