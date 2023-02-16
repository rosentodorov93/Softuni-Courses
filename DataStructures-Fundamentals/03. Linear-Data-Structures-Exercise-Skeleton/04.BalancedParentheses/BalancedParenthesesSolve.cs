namespace Problem04.BalancedParentheses
{
    using System;
    using System.Collections.Generic;

    public class BalancedParenthesesSolve : ISolvable
    {
        public bool AreBalanced(string parentheses)
        {
            var stack = new Stack<char>();

            for (int i = 0; i < parentheses.Length; i++)
            {
                if (parentheses[i] == '{' || parentheses[i] == '[' || parentheses[i] == '(')
                {
                    stack.Push(parentheses[i]);
                }
                else if (stack.Count == 0)
                {
                    return false;
                }
                else if (parentheses[i] == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else if (parentheses[i] == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (parentheses[i] == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
              
            }

            return stack.Count == 0;
        }
    }
}
