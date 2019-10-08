using System;

//name space 
namespace NumberGuesser
{   //main class
    class Program
    {
        //entry point method
        static void Main(string[] args)
        {
            //show app info
            GetAppInfo();

            //read user
            ReadUser();

            while (true)
            {
                //create a new random number as correct number
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    //make sure it is a nubmer
                    if (!int.TryParse(input, out guess))
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red,"Pleas use a actual number");
                        //keep going
                        continue;
                    }

                    //Cast to int and put into guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong message, try again");
                    }

                }

                //output success message

                PrintColorMessage(ConsoleColor.Yellow, "You are correct!");

                //ask if user want to play again
                Console.WriteLine("Play again?[Y or N]");

                //get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue; 
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

            

        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string author = "Yuhang Xiong";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;
            //write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, author);
            //reset text color
            Console.ResetColor();
        }


        static void ReadUser()
        {
            //ask user's name
            Console.WriteLine("What is your name?");
            //get input
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color,string message)
        {
            //change text color
            Console.ForegroundColor = color;
            //tell user it is not a number
            Console.WriteLine(message);
            //reset text color
            Console.ResetColor();
        }
    }
}
