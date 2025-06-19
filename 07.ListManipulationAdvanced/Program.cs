/*
 * 07.ListManipulationAdvanced
 */

namespace _07.ListManipulationAdvanced;

class Program
{
    static void Main()
    {
        RunListManipulator();
    }

    static void RunListManipulator()
    {
        List<int> numbers = (Console.ReadLine() ?? "6 6 6")
            .Split()
            .Select(int.Parse)
            .ToList();

        string[] methodComponents = (Console.ReadLine() ?? "6 6 6")
            .Split();

        while (methodComponents[0] != "end")
        {
            string command = methodComponents[0];
            object param1 = ">";
            int param2 = default;

            if (methodComponents.Length == 2)
            {
                param1 = int.Parse(methodComponents[1]);
            }

            if (methodComponents.Length == 3)
            {
                param1 = methodComponents[1];
                param2 = int.Parse(methodComponents[2]);
            }

            //•	Contains { number} – check if the list contains the number and if so - print "Yes",
            //   otherwise print "No such number".
            //•	PrintEven – print all the even numbers, separated by a space.
            //•	PrintOdd – print all the odd numbers, separated by a space.
            //•	GetSum – print the sum of all the numbers.
            //•	Filter { condition} { number} – print all the numbers that fulfill the given condition.
            //   The condition will be either '<', '>', ">=", "<=".
            switch (command)
            {
                case "Contains":
                    Console.WriteLine(value: numbers.Contains((int)param1) ? "Yes" : "No such number");
                    break;
                case "PrintEven":
                    Console.WriteLine(value: SeparateEvents(collection: numbers));
                    break;
                case "PrintOdd":
                    Console.WriteLine(value: SeparateOdds(collection: numbers));
                    break;
                case "GetSum":
                    Console.WriteLine(value: numbers.Sum());
                    break;
                case "Filter":
                    Console.WriteLine(value: FilterByCondition(
                        collection: numbers,
                        condition: (string)param1,
                        conditionValue: param2
                    ));
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                break;
            }

            methodComponents = (Console.ReadLine() ?? "6 6 6")
                .Split();
        }
    }

    static string SeparateEvents(List<int> collection)
    {
        List<int> buffer = new();
        foreach (int number in collection)
        {
            if (number % 2 == 0)
            {
                buffer.Add(number);
            }
        }

        return String.Join(' ', buffer);
    }

    static string SeparateOdds(List<int> collection)
    {
        List<int> buffer = new();
        foreach (int number in collection)
        {
            if (number % 2 != 0)
            {
                buffer.Add(number);
            }
        }

        return String.Join(' ', buffer);
    }

    static string FilterByCondition(List<int> collection, string? condition, int conditionValue)
    {
        List<int> buffer = new();
        switch (condition)
        {
            case "<":
                foreach (int number in collection)
                {
                    if (number < conditionValue)
                    {
                        buffer.Add(number);
                    }
                }
                break;
            case ">":
                foreach (int number in collection)
                {
                    if (number > conditionValue)
                    {
                        buffer.Add(number);
                    }
                }
                break;
            case "<=":
                foreach (int number in collection)
                {
                    if (number <= conditionValue)
                    {
                        buffer.Add(number);
                    }
                }
                break;
            case ">=":
                foreach (int number in collection)
                {
                    if (number >= conditionValue)
                    {
                        buffer.Add(number);
                    }
                }
                break;
            default:
                buffer.AddRange(new List<int> { 6, 6, 6 });
            break;
        }

        return String.Join(' ', buffer);
    }
}