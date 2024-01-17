using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace StringManipulation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string contents = "";
            
            try
            {
                string path = @"Files/Words.txt";
                string fileName = Path.GetFileName(path);
                using (var sr = new StreamReader(path))
                {
                    contents = sr.ReadToEnd();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("File could not be read");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("---------------------------------------------");
            var array = contents.Split("\n", StringSplitOptions.RemoveEmptyEntries);
            
            Random randomNumber = new Random();
            


            while (true) {
                int rdnNumber = randomNumber.Next(0, array.Length);
                string guessWord = array[rdnNumber].Trim().ToLower();
                Game(guessWord);
                Console.WriteLine("Would you like to play again?\n" +
                    "yes or no");
                string input = Console.ReadLine().Trim().ToLower();
                if (input.Equals("no"))
                {
                    break;
                }
            }
        }

        public static void Game(string word)
        {
            List<positionOfCharacter> list = new List<positionOfCharacter>();
            Player player = new Player(7);
            List<char> wordToGuess = new List<char>(new string('_', word.Length-1));
            Console.WriteLine("Welcome Player! \n" +
                "To play the game, you need to guess what word i am thinking of by typing only one letter at a time. You have 3 lives. Good luck!");
            
            while (player.getlives() > 0)
            {
                int index = 0;
                Console.WriteLine("Enter your guess (a character): ");
                string letter = Console.ReadLine().Trim().ToLower();
                

                if (word.Contains(letter))
                {
                    if (word.IndexOf(letter) != -1)
                    {
                        while ((index = word.IndexOf(letter, index)) != -1)
                        {
                            wordToGuess[index] = letter[0];
                            Console.WriteLine("word: " + word + " " + letter + " found at position: " + index);
                            index++;
                            list.Add(new positionOfCharacter() { nameOfWord = word, c = letter, pos = index });
                        }
                    }
                    Console.WriteLine(string.Join(" ", wordToGuess));

                }
                else
                {
                    player.setlives(player.getlives() - 1);
                    Console.WriteLine("You have " + player.getlives() + " attempts left!");
                    player.getWrongGuesses();
                }

                if (letter.Equals(word))
                {
                    Console.WriteLine("Congratulations, You have won!");
                    break;
                }
                else if (!letter.Equals(word) && player.getlives() == 0)
                {
                    Console.WriteLine("Game Over!");
                }
            }
        }

        
    }
}
