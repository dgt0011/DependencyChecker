﻿using CommandLine;
using DependencyChecker.Model;
using System;

namespace DependencyChecker
{
    internal class Program
    {
        /// <summary>
        ///     Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(options =>
                {
                    // Print options
                    Console.WriteLine("Options: ");
                    var properties = options.GetType().GetProperties();
                    foreach (var propertyInfo in properties)
                    {
                        Console.WriteLine(string.Concat("\t", propertyInfo.Name, ":\t", propertyInfo.GetValue(options)));
                    }

                    if (options.CreateBadge && (string.IsNullOrEmpty(options.BadgePath)))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("For badge creation path must be set!");
                        return;
                    }

                    if (options.CreateReport && string.IsNullOrEmpty(options.ReportPath))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("For report creation path must be set!");
                        return;
                    }

                    Console.WriteLine(); // Blank line
                    new Runner().Run(options);
                });
        }
    }
}