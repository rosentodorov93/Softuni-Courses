using Problem01.List;

namespace DemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Problem02.Stack.Stack<int>();

            var numbers = new int[]{ 1,3,4,5,6};

            foreach (var number in numbers)
            {
                stack.Push(number);
            }

        }
    }
}