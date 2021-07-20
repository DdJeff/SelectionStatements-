using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int tracker = 0;
            bool test = true;


            //Ask user for imput and store it
            Console.WriteLine("Guess a number!");
            var userInput = int.Parse(Console.ReadLine());

            

            while (test) { 
                 
            var favNumber = r.Next(1, 1000);

  
            if(userInput < favNumber)//check if guess is less then favnumber
            {

                Console.WriteLine("Too Low, this will go on forever!");
                tracker++;
            }
            else if (userInput > favNumber)//check if guess is greater then favnumber
                {

                Console.WriteLine("Too high, this will go on forever!");
                tracker++;
            }
            else
            {
                Console.WriteLine($"Never mind, You Got It! It only took {tracker} trys!"); //log congrads and count
                test = false; //close loop
                }
           }

        }
    }
}
