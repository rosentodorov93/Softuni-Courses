using System;

namespace _1.ClassBoxData
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(lenght, widht, height);

                Console.WriteLine($"Surface Area - {box.GetSurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurface():f2}");
                Console.WriteLine($"Volume - {box.GetVolume():f2}");
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
