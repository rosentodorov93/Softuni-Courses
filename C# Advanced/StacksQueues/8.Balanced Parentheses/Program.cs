using System;
using System.Collections.Generic;

namespace _8.Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<char> brackets = new Queue<char>(input);
            
            bool isBalanced = true;

            if (input.Length % 2 == 1)
            {
                Console.WriteLine("NO");
            }
            else
            {
                int count = 0;
                
                while (brackets.Count > 0 )
                {
                    char currentSymbol = brackets.Dequeue();
                    char next = brackets.Peek();


                    if (currentSymbol == '(')
                    {
                        if (next == ')')
                        {
                            brackets.Dequeue();
                            count = 0;
                            continue;
                        }
                        else
                        {
                            brackets.Enqueue(currentSymbol);
                            
                        }
                    }
                    else if (currentSymbol == '{')
                    {
                        if (next == '}')
                        {
                            brackets.Dequeue();
                            count = 0;
                            continue;
                        }
                        else
                        {
                            brackets.Enqueue(currentSymbol);

                        }
                    }
                    else if (currentSymbol == '[')
                    {
                        if (next == ']')
                        {
                            brackets.Dequeue();
                            count = 0;
                            continue;

                        }
                        else
                        {
                            brackets.Enqueue(currentSymbol);

                        }
                    }
                    else
                    {
                        brackets.Enqueue(currentSymbol);
                    }
                    count++;
                    if (count > brackets.Count)
                    {
                        isBalanced = false;
                        break;
                    }
                }

                if (isBalanced)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
