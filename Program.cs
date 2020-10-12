using System;
using static System.Console;
using System.Text.RegularExpressions;

namespace Stack_Queue_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawUserInput;
            string userInput;
            string repeatProgram;


            Write("Give me a palindrome! --> ");
            rawUserInput = ReadLine().ToUpper();

            do
            {
                Regex regularExpression = new Regex("[^A-Z0-9]");
                userInput = regularExpression.Replace(rawUserInput, "");

                char[] array = userInput.ToCharArray();

                Write("Give me another palindrome! (say 'no' to exit) --> ");
                repeatProgram = ReadLine().ToUpper();
                if (repeatProgram != "NO")
                {
                    rawUserInput = repeatProgram;
                }

            } while (repeatProgram != "NO");

            WriteLine("Later gator!");

        }
    }
}
