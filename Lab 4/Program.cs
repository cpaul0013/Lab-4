using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            exponentFun();
        }


        public static void exponentFun()

        {
            Console.WriteLine("Welcome to the square and cubed number table generator");
            bool runProgram = true;
            while (runProgram)
            {
                bool validInput = false;
                int userNumber;
                while (!validInput && runProgram)
                {
                    
                    Console.Write("Please enter a number: ");
                    userNumber = int.Parse(Console.ReadLine());
                    if (userNumber > 0 && userNumber <= 1290)
                    {
                        

                        Console.WriteLine("Number\tSquared\tCubed");
                        for (int i = 1; i <= userNumber; i++)
                        {

                            Console.WriteLine($"{i, 5}" + $"\t {i * i, 5}" + $"\t {i * i * i, 5}");



                        }
                        Console.Write("Would you like to continue? Y / N: ");
                        string response = Console.ReadLine();
                        if (response == "N" || response == "n")
                        {
                            runProgram = false;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1 - 1290");
                    }


                    
                }
                
            }
            }

            
        }
    
}
