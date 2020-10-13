using System;
using static System.Console;
using System.Text.RegularExpressions;

namespace Stack_Queue_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Regex regularExpression = new Regex("[^A-Z0-9]");
            CustomStack<char> stack = new CustomStack<char>();
            CustomQueue<char> queue = new CustomQueue<char>();

            Write("Give me a palindrome! --> ");
            userInput = ReadLine().ToUpper();

            while (userInput != "NO")
            {
                userInput = regularExpression.Replace(userInput, "");
                WriteLine($"Checking to see if {userInput} is case sensitive.");
                char[] array = userInput.ToCharArray();

                foreach (char item in array)
                {
                    stack.Push(item);
                    queue.Enqueue(item);
                }

                int index = 0;

                while (index < array.Length && queue.Peek() == stack.Peek())
                {
                    WriteLine($"{index + 1,3} Dequeued char is {queue.Dequeue()}, popped char is {stack.Pop()}.");
                    index++;
                }

                if (index >= array.Length)
                {
                    WriteLine("This is a case sensitive palindrome!");
                }
                else
                {
                    WriteLine($"{index + 1,3}Dequeued char is {queue.Dequeue()}, popped char is {stack.Pop()}.");
                    WriteLine("Sorry, this isn't a palindrome");
                }

                Write("Give me another palindrome! (say 'no' to exit) --> ");
                userInput = ReadLine().ToUpper();
                queue.Clear();
                stack.Clear();
            }
            WriteLine("Ah, Aibohphobia!");
        }
    }
}
