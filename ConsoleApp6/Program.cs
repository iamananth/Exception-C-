using System;

namespace ConsoleApp6
{
    class Program
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access Denied");
            }
            else
            {
                Console.WriteLine("Access Granted");
            }
        }
        static void Main(String[] args)
        {
            /* try
             {
                 int[] mynumbers = { 1, 2, 3, 4, 5, 6 };
                 Console.WriteLine(mynumbers[10]);
             }
             catch(Exception e)
             {
                 Console.WriteLine("Sorryyyyy");
             }
             finally
             {
                 Console.WriteLine("Finally");
             }
            */
            checkAge(15);
        }
    }
}