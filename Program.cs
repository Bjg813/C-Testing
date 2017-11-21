using System;

namespace teamtreehouse_c_
{
    class Program
    {
        static void Main(string[] args)
        {
           int answer = 0;

            while(true) {
            Console.WriteLine("Please Create a Username or type \"quit\" to exit");
            string username = Console.ReadLine();
            if(username == "quit")
            {
                break;
            }
            Console.WriteLine("Please create a password");
            string password = Console.ReadLine();
            Console.WriteLine("Please enter your Username");
            string usrname = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string pwd = Console.ReadLine();

            if (pwd == password && usrname == username) 
            {
            // Ask the user three multiple choice questions or true/false
            Console.WriteLine("Maine is the closest U.S. state to Africa?");
            Console.WriteLine("(t) true or (f) false");
            string answer1 = Console.ReadLine();
            if (answer1 == "t")
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
                answer ++;
            }
            Console.WriteLine("Is it true there are three ducks in a row?");
            Console.WriteLine("(t) true or (f) false");
            string answer2 = Console.ReadLine();
            if (answer2 == "t")
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
                answer ++;
            }
            Console.WriteLine("Is Carmen San Diego a wolrd traveler?");
            Console.WriteLine("(t) true or (f) false");
            string answer3 = Console.ReadLine();
            if (answer3 == "t")
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
                answer ++;
            }
            }
            else
            {
            Console.WriteLine("Inconrrect username or password please try again...");
            continue;
            }
            Console.WriteLine("You answered " + answer + " out of 3 incorrectly");
            } // End While Loop
            Console.WriteLine("Goodbye!");
        }
    }
}
