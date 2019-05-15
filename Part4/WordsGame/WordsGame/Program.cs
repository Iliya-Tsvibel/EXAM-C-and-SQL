using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playAgain = 1, NumberLettersLeftToGuess = 0, NumberOfTries = 0;
            Random rand = new Random();
            int numWordInArray = 0;
            string chosenWord = "";
            char[] guessedWord = null;
            while (playAgain == 1)
            {
             
                string[] boxWord =
                {
                "USSR", "USA" , "world", "sex", "girl", "gun", "car", "hara","batata", "eurovision"
                };
                numWordInArray = rand.Next(0, boxWord.Length);
                chosenWord = boxWord[numWordInArray];
                guessedWord = new char[chosenWord.Length];
                for (int i = 0; i < guessedWord.Length; i++)
                {
                    guessedWord[i] = '*';
                }
                Console.WriteLine($"The number of letter in choosen word is {chosenWord.Length}");
                Console.WriteLine("Let's see how dear to you life. Game started!");

                for (int i = 0; i < chosenWord.Length; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                NumberLettersLeftToGuess = chosenWord.Length;
                while (NumberLettersLeftToGuess > 0)
                {
                    Console.WriteLine("You can choose only one letter from the word. Please write:");
                    string letter = Console.ReadLine();
                                       
                    if (chosenWord.Contains(letter))
                    {
                        for (int i = 0; i < chosenWord.Length; i++)
                        {
                            if (chosenWord[i] == letter[0])
                            {
                               
                                NumberLettersLeftToGuess--;
                                for (int j = 0; j < chosenWord.Length; j++)
                                {
                                    if (j == i)
                                    {
                                        guessedWord[j] = chosenWord[i];
                                    }
                                }
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Letter that was guessed = {new string(guessedWord)}");
                    }
                    else
                    {
                        Console.WriteLine("Try again or die!");
                    }
                    Console.WriteLine();
                    NumberOfTries++;
                }

                Console.WriteLine($"Congratulations, you guessed the word. Now you will value your life more. 'Saw'. \n Number of Tries is {NumberOfTries}");
                Console.WriteLine("Risk again? Press 1 Else press 2");

                playAgain = Convert.ToInt32(Console.ReadLine());
                NumberOfTries = 0;
            }
        }
    }
}
