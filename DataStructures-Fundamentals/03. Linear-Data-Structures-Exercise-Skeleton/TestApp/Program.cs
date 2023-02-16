namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reversedList = new Problem03.ReversedList.ReversedList<int>();
            var numbers = new int[] { 3, 5, 7, 1, -5, -100 };
            foreach (var number in numbers)
            {
                reversedList.Add(number);
            }

           reversedList.Insert(reversedList.Count - 1, 100);
        }
    }
}