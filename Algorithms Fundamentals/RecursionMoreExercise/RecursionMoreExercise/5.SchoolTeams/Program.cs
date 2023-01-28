using System;
using System.Linq;
using System.Collections.Generic;
namespace _5.SchoolTeams
{
    public class Program
    {
        static int girlsTeamSize;
        static int boysTeamSize;
        static void Main(string[] args)
        {
            string[] girlsNames = Console.ReadLine().Split(", ").ToArray();
            string[] boysNames = Console.ReadLine().Split(", ").ToArray();

            girlsTeamSize = 3;
            boysTeamSize = 2;

            List<string> girlsTotalCombinations  = new List<string>();
            List<string> boysTotalCombinations  = new List<string>();

            string[] singleGirlCombination = new string[girlsTeamSize];
            string[] singleBoyCombination = new string[boysTeamSize];

            GenerateCombinations(girlsTotalCombinations, singleGirlCombination, girlsNames, 0, 0);
            GenerateCombinations(boysTotalCombinations, singleBoyCombination, boysNames, 0, 0);

            foreach (var girlCombination in girlsTotalCombinations)
            {
                foreach (var boyCombination in boysTotalCombinations)
                {
                    Console.WriteLine(girlCombination + ", " + boyCombination);
                }   
            }

        }

        private static void GenerateCombinations(List<string> collection, string[] combination, string[] names, int index, int start)
        {
            if (index >= combination.Length)
            {
                collection.Add(string.Join(", ", combination));
                return;
            }

            for (int i = start; i < names.Length; i++)
            {
                combination[index] = names[i];
                GenerateCombinations(collection, combination, names, index + 1, i + 1);
            }
        }
    }
}