using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string level; 

            Console.WriteLine("Whats your name?");
            name = Console.ReadLine();
            Console.WriteLine("You are welcome to the Guessing Game "+ name );
            Console.WriteLine("You can always select from the following Levels available : \r\n Level 1: EASY \r\n Level 2: INTERMEDIATE \r\n Level 3: HARD");

            Console.WriteLine("Now pick a level by typing either of the following : \r\n EASY \r\n INTERMEDIATE \r\n HARD");
            level = Console.ReadLine();

            if (level == "EASY")
            {
                Console.WriteLine("Welcome to level1 \r\nGuess a number between 1-10 \r\nYou have only 6 trials! \r\nSTART GUESSING NOW !!!!");
                  while (true)
            {
                 
              for(int i = 0; i < 6; i++)
                {
                    int input = 0;
                   int randno = Newnum(1, 10);
                    //int randomNumber = new Random().Next(1,10);
                    Console.Write("Enter a number between 1 and 10(0 to quit):");
                    input = int.Parse(Console.ReadLine());

                    if (input == 0)
                        return;

                    else if (input != randno)
                    {
                        Console.WriteLine("Try Again");
                    }
                   
                    else
                    {
                        Console.WriteLine("You guessed it! The number was {0}!", 
                                           randno);
                        Console.WriteLine("It took you {0} {1}.\n", i, 
                                           i == 1 ? "try" : "tries");
                        break;
            
                    }
                   
                }
            }
 
        }
 
        static int Newnum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

if (level == "INTERMEDIATE")
            {
                Console.WriteLine("Welcome to level2 \r\nGuess a number between 1-20 \r\nYou have only 4 trials! \r\nSTART GUESSING NOW !!!!");
          
                 
              for(int i = 0; i < 4; i++)
                {
                    int input = 0;
                    int randno2 = new Random().Next(1,20);
                   
                    Console.Write("Enter a number between 1 and 20(0 to quit):");
                    input = int.Parse(Console.ReadLine());

                    if (input == 0)
                        return;

                    else if (input != randno2)
                    {
                        Console.WriteLine("Try Again");
                    }
                 
                    else
                    {
                        Console.WriteLine("You guessed it! The number was {0}!", 
                                           randno2);
                        Console.WriteLine("It took you {0} {1}.\n", i, 
                                           i == 1 ? "try" : "tries");
                        break;
            
                    }
                   
                }
            
 
        }

if (level == "HARD")
            {
                Console.WriteLine("Welcome to level2 \r\nGuess a number between 1-50 \r\nYou have only trials! \r\nSTART GUESSING NOW !!!!");
          
                 
              for(int i = 0; i < 6; i++)
                {
                    int input = 0;
                    int randno3 = new Random().Next(1,50);
                   
                    Console.Write("Enter a number between 1 and 50(0 to quit):");
                    input = int.Parse(Console.ReadLine());

                    if (input == 0)
                        return;

                    else if (input != randno3)
                    {
                        Console.WriteLine("Try Again");
                    }
                 
                    else
                    {
                        Console.WriteLine("You guessed it! The number was {0}!", 
                                           randno3);
                        Console.WriteLine("It took you {0} {1}.\n", i, 
                                           i == 1 ? "try" : "tries");
                        Console.WriteLine("You have successfully completed this game Genius!. Type 0 to exit or replay");                        break;
            
                    }
                   
                }
            
 
        }







            }
    
    }
}
