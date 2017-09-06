using System;
/// <summary>
/// A simple example of Blackjack card game
/// </summary>

namespace Hello
{
    public class BlackJack
    {
        public static void mustajaska()
        {
            int myNumber = 17;
            int theirNumber;



            {
                System.Console.WriteLine("*** BlackJack! ***");
                System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
                //reading and converting 
                string consent = Console.ReadLine();
                theirNumber = System.Convert.ToInt32(System.Console.ReadLine());
                //comparing that given umber is valid
                while (consent != "x")
                {
                    do
                    {
                        Console.WriteLine("The given number is out of limits, try again.");
                        System.Console.Write("Enter any number between 1-21: ");
                        theirNumber = System.Convert.ToInt32(System.Console.ReadLine());

                    } while (theirNumber < 1 || theirNumber > 21);

                    //comparing
                    if (theirNumber >= myNumber && theirNumber <= 21)
                    {
                        System.Console.WriteLine("You win.");
                    }
                    else
                    {
                        System.Console.WriteLine("You lose.");
                    }
                }
            }
        }
    }
}