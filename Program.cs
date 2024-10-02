using System;

namespace IntroductionToProgramming//ProgrammingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction to Programming
            //Console.WriteLine("Running Introduction to Programming (Basic Syntax)...");
            // IntroductionToProgramming.VariablesAndDataTypes.RunExample();
            // IntroductionToProgramming.ControlStructures.RunExample();
            // IntroductionToProgramming.BasicSyntax.RunExample();

            // Data Structures
            // Console.WriteLine("Running Data Structures...");
            // DataStructures.Arrays.ArraysBasics.RunExample();
            // DataStructures.Strings.StringManipulation.RunExample();
            //DataStructures.Dictionaries.DictionaryOperations.RunExample();

            // Sorting Algorithms
            // Console.WriteLine("Running Sorting Algorithms...");
            // SortingAlgorithms.BubbleSort.RunExample();
            // SortingAlgorithms.QuickSort.RunExample();
            // SortingAlgorithms.MergeSort.RunExample();

            // Searching Algorithms
            // Console.WriteLine("Running Searching Algorithms...");
            // SearchingAlgorithms.BinarySearch.RunExample();
            // SearchingAlgorithms.LinearSearch.RunExample();
            // SearchingAlgorithms.SearchTimeComparison.RunExample();

            // Big O Notation
            // Console.WriteLine("Running Big O Notation Examples...");
            // BigOExamples.BigOExamples.RunExample();

            // Algorithms (Recursion, Divide and Conquer, Dynamic Programming)
            // Console.WriteLine("Running Algorithms...");
            // Algorithms.Recursion.Fibonacci.RunExample();
            // Algorithms.DivideAndConquer.MergeSort.RunExample();
            // Algorithms.DynamicProgramming.KnapsackProblem.RunExample();

            // Object-Oriented Programming (OOP)
            // Console.WriteLine("Running Object-Oriented Programming Examples...");
            // OOPs.ClassesAndObjects.ClassesAndObjectsExample.RunExample();
            // OOPs.Inheritance.InheritanceExample.RunExample();
            // OOPs.Polymorphism.PolymorphismExample.RunExample();
            // OOPs.Interfaces.InterfacesExample.RunExample();

            // Program execution completed
            //Console.WriteLine("\nProgram execution completed.");


            // Create Dictionary 

            // Create a dictionary with int keys and double values
            Dictionary<int, double> myDictionary = new Dictionary<int, double>();
            Random random = new Random();

            // Populate dictionary with 10 items, with keys between 1-20
            for (int i = 0; i < 10; i++)
            {
                int key = random.Next(1, 21); // Random key between 1 and 20
                double value = random.NextDouble() * 100; // Random double value between 0 and 100
                if (!myDictionary.ContainsKey(key))
                {
                    myDictionary.Add(key, value);
                }
                else
                {
                    i--; // If the key already exists, decrement i to ensure 10 unique entries
                }
            }

            // Print dictionary contents
            Console.WriteLine("Dictionary contents:");
            foreach (var kvp in myDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Search for 4 random keys in the dictionary and handle found/not found scenarios
            Console.WriteLine("\nSearching for 4 random keys:");
            for (int i = 0; i < 4; i++)
            {
                int searchKey = random.Next(1, 21); // Random key between 1 and 20
                if (myDictionary.TryGetValue(searchKey, out double foundValue))
                {
                    Console.WriteLine($"Key {searchKey} found with value: {foundValue}");
                }
                else
                {
                    Console.WriteLine($"Key {searchKey} not found.");
                }
            }
        }
    }
}
