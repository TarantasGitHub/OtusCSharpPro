﻿// See https://aka.ms/new-console-template for more information
using ConsoleApp;

namespace Consoleapp;
public class Program
{
    public static Task Main()
    {
        // var ints = new List<int>() { 1, 2, 3, 4, 5 };
        var ints = DataGenerator.Generate(100000000);
        var calculatorCollection = new List<ICalculation>();
        calculatorCollection.Add(new SequentialCalculation());
        calculatorCollection.Add(new ParallelCalculation());
        calculatorCollection.Add(new TaskCalculation(10000));

        Int64 result = 0;
        foreach (var calculator in calculatorCollection)
        {
            result = calculator.Sum(ints);
            Console.WriteLine("Calculator: {0}, Sum: {1}, Milliseconds: {2}",
                calculator.GetType().Name,
                result,
                calculator.Milliseconds
            );
        }
        Console.ReadKey();
        return Task.CompletedTask;
    }
}
