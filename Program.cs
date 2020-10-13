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
            Regex regularExpression = new Regex("[^A-Z0-9]");
            CustomStack<char> stack = new CustomStack<char>();
            CustomQueue<char> queue = new CustomQueue<char>();

            Write("Give me a palindrome! --> ");
            rawUserInput = ReadLine().ToUpper();

            do
            {
                userInput = regularExpression.Replace(rawUserInput, "");

                char[] array = userInput.ToCharArray();

                foreach (char item in array)
                {
                    stack.Push(item);
                    queue.Enqueue(item);
                }

                Write("Give me another palindrome! (say 'no' to exit) --> ");
                repeatProgram = ReadLine().ToUpper();
                if (repeatProgram != "NO")
                {
                    rawUserInput = repeatProgram;
                }



            } while (repeatProgram != "NO");

            WriteLine("Ah, Aibohphobia!");

        }
    }
}
