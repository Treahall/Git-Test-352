using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am thinking of a number between 0 and 100\n");
            Random random = new Random();
            int randomNum;
            int UsrGuess;
            int tries;
            string play;
            string yes = "Yes";

            
            do
            {
                Console.WriteLine("===================================================");
                Console.Write("Try and guess what number I'm thinking: ");
                randomNum = random.Next(100);
                tries = 0;
                do
                {
                    tries++;
                    UsrGuess = Convert.ToInt32(Console.ReadLine());

                    if (UsrGuess < randomNum)
                    {
                        Console.Write("You were too low. :(\nGuess again: ");

                    }
                    else if (UsrGuess > randomNum)
                    {
                        Console.Write("You were too high. :(\nGuess again: ");

                    }
                    else
                        Console.Write("You were correct!!");


                } while (UsrGuess != randomNum);

                Console.WriteLine("It took you {0} atempts!", tries);
                Console.Write("Care to play again? (Yes or No): ");
                play = Console.ReadLine();

            } while (play == yes);
            
            

            Console.ReadKey();
        }
    }
}
