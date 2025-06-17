/*
 * 06.ListManipulationBasics
 */

using System.Collections.Generic;

namespace _06.ListManipulationBasics;

class Program
{
    static void Main()
    {
        //4 19 2 53 6 43
        //Add 3
        //Remove 2
        //RemoveAt 1
        //Insert 8 3
        //end

        List<int> numbers = (Console.ReadLine() ?? "6 6 6 6")
            .Split()
            .Select(int.Parse)
            .ToList();

        string[] commandComponents = (Console.ReadLine() ?? "Add 666")
            .Split();

        while (commandComponents[0] != "end")
        {
            string cmd = commandComponents[0];
            int parameter = int.Parse(commandComponents[1]);
            int index = default;

            if (commandComponents.Length == 3)
            {
                index = int.Parse(commandComponents[2]);
            }

            switch (cmd)
            {
                case "Add":
                    numbers.Add(parameter);
                    break;
                case "Remove":
                    numbers.Remove(parameter);
                    break;
                case "RemoveAt":
                    numbers.RemoveAt(parameter);
                    break;
                case "Insert":
                    numbers.Insert(index, parameter);
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                break;
            }

            commandComponents = (Console.ReadLine() ?? "Add 1")
            .Split();
        }

        Console.WriteLine(String.Join(' ', numbers));
    }
}