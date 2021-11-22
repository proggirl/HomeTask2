using System;

namespace Lesson3Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Write a method named isEven that accepts an int argument. The method should return true if the argument is even,
            // or false otherwise.Also write a program to test your method.

            int i = int.Parse(Console.ReadLine());

            if(isEven(i))
            {
                Console.WriteLine(i + " is even");
            }
            else
            {
                Console.WriteLine(i + " is odd");
            }

            //Не получается :(


            //2) A person is elligible to vote if his / her age is greater than or equal to 18.
            //    Define a method to find out if he / she is elligible to vote.

            Console.WriteLine("Enter your age: ");

            int c = int.Parse(Console.ReadLine());
            if (voteAge(c) )
            {
                Console.WriteLine("You elligible to vote");
            }
            else
            {
                Console.WriteLine("You're not elligible to vote");
            }


             // 3) Write a program to print the sum of two numbers entered by user by defining your own method.

             Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Result: "+  Sum(a, b));
            

            Console.ReadLine();
        }
      
         public static bool isEven( int i)
        {
            return (i % 2) == 0;               
        }

        public static bool voteAge(int c)
        {
            return c >= 18;
        }

        public static int Sum (int a, int b)
        {
            return a + b;
        }
    
    }
}
