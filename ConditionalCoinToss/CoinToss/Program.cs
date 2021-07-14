using System;

/*
 * 
 * @author Keishon Rose
 * version 7/14/2021
 * 
 */


namespace CoinToss
{
    class Program
    {
        public static int assignedNum;
        public static int randNum;
        public static string userChoice;
        public static int actualNum;
        
        
        public static void CoinSelector()
        {
            var rand = new Random();
            randNum = rand.Next(1, 3);
            actualNum = randNum;

            Console.WriteLine("Hello There! Please choose heads or tails.");
            userChoice = Console.ReadLine().ToLower();
            if (userChoice == "heads")
            {
                assignedNum = 1;
                Console.WriteLine("You chose heads!");
            }
            else
            {
                assignedNum = 2;
                Console.WriteLine("You chose tails!");

            }

            if (assignedNum == 1 && actualNum == 1)
            {
                Console.WriteLine("The coin landed on heads! You Won!");
            }
            else if (assignedNum == 1 && actualNum == 2)
            {
                Console.WriteLine("The coin landed on tails! You lost :( ");
            }
            else if (assignedNum == 2 && actualNum == 2)
            {
                Console.WriteLine("The coin landed on tails! You Won!");
            }
            else
            {
                Console.WriteLine("The coin landed on heads! You lost :( ");
            }

           


        }
        public static void Main(string[] args)
        {
            /*This code allows main to execute the coin side selector method and give the option to play again
             * back to the user if they would like to. If they don't say yes, the program will stop. I did it this way 
             * instead of calling main() again to avoid an infinite loop of restarting the game.
             */
            do
            {
                CoinSelector();
                Console.WriteLine("Would you like to play again?");
            }
            while (Console.ReadLine().ToLower() == "yes");
        }
    }
}
