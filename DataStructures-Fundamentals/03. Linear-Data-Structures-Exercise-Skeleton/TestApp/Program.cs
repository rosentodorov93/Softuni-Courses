namespace TestApp
{
    internal class Program
    {
        private class Item
        {
            public Item(int value, Item previous)
            {
                Value = value;
                Previous = previous;
            }

            public int Value { get; set; }
            public Item Previous { get; set; }
        }
        static void Main(string[] args)
        {
            //int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();


            //StackReverse(numbers);
            //CallculateSequence(n);
            ShotrtestSequence(input[0], input[1]);
        }

        private static void ShotrtestSequence(int n, int m)
        {
            var queue = new Queue<Item>();
            queue.Enqueue(new Item(n, null));
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current.Value < m)
                {
                    queue.Enqueue(new Item((current.Value + 1),current));
                    queue.Enqueue(new Item((current.Value + 2),current));
                    queue.Enqueue(new Item((current.Value * 2),current));

                }
                if (current.Value == m)
                {
                    PrintSolution(current);
                    return;
                }
            }
            Console.WriteLine("(no solution)");
        }

        private static void PrintSolution(Item current)
        {
            var stack = new Stack<int>();
            
            while (current != null)
            {
                stack.Push(current.Value);
                current = current.Previous;
            }
            Console.WriteLine(String.Join(" -> ", stack));
        }

        private static void CallculateSequence(int n)
        {
            var queue = new Queue<int>();
            List<int> list = new List<int>();
            queue.Enqueue(n);
            for (int i = 0; i < 50; i++)
            {
                int current = queue.Dequeue();
                list.Add(current);
                queue.Enqueue(current + 1);
                queue.Enqueue((2 * current) + 1);
                queue.Enqueue(current + 2 );
            }

            Console.WriteLine(String.Join(", ",list));
        }

        private static void StackReverse(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                Console.WriteLine("(empty)");
            }
            else
            {
                var stack = new Stack<int>();

                foreach (int number in numbers)
                {
                    stack.Push(number);
                }
                while (stack.Count > 0)
                {
                    Console.Write(stack.Pop() + " ");
                }
            }
        }

    }
}