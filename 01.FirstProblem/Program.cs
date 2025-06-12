

using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

/**
 * 01.FirstProblem
 */
namespace _01.FirstProblem;

class Program
{
    static void Main()
    {
        List<double> numbers = (Console.ReadLine() ?? "666 6 666")
            .Split()
            .Select(double.Parse)
            .ToList();

        for (int i = 0; i < numbers.Count - 1; ++i)
        {
            if (numbers[i] == numbers[i + 1])
            {
                numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);
                i = -1;
            }
        }

        Console.WriteLine(String.Join(' ', numbers));
    }
}