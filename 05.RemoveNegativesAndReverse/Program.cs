/*
 * 05.RemoveNegativesAndReverse
 */

namespace _05.RemoveNegativesAndReverse;

class Program
{
    static void Main()
    {
        List<int> numbers = (Console.ReadLine() ?? "6 6 6")
            .Split()
            .Select(int.Parse)
            .ToList();

        numbers.RemoveAll(x => Math.Sign(x) == -1);
        numbers.Reverse();

        Console.WriteLine(String.Join(' ', numbers));
    }
}