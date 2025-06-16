/**
 * 02.GaussTrick
 */

namespace _02.GaussTrick;

class Program
{
    static void Main()
    {
        List<int> numbers = (Console.ReadLine() ?? "6 6 6")
            .Split()
            .Select(int.Parse)
            .ToList();

        for (int i = 0; i <= numbers.Count / 2; i++)
        {
            numbers[i] += numbers[numbers.Count - 1];
            numbers.RemoveAt(numbers.Count - 1);
        }

        Console.WriteLine(String.Join(' ', numbers));

        Math.Min(3, 6);
    }
}