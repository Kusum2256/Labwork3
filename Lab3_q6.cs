using System;

namespace Labwork
{
    // Step 1: Create your own custom exception class
    public class UnderAgeException : Exception
    {
        public UnderAgeException(string message) : base(message)
        {
        }
    }

    internal class Lab3_q6
    {
        /*static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                // Step 2: Use the custom exception
                if (age < 18)
                {
                    throw new UnderAgeException("You must be at least 18 years old.");
                }

                Console.WriteLine("You are eligible!");
            }
            catch (UnderAgeException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            finally
            {
                Console.WriteLine("Program finished.");
            }
        }*/
    }
}

