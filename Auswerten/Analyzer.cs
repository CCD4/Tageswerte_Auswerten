using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Auswerten
{
    public class Analyzer
    {
        public static IEnumerable<decimal> ReadData()
        {
            var lines =
                File.ReadAllLines(
                    @"C:\Users\svenk\Documents\visual studio 2015\Projects\Auswerten\Auswerten\tageswerte.txt");
            return lines.Select(decimal.Parse);
        }

        public static void AskAnalysisMethod(Action onSumRequested, Action onAverageRequested)
        {
            while (true)
            {
                Console.Write("(S)umme (M)ittelwert (E)nde:");
                var line = Console.ReadLine();
                switch (line)
                {
                    case "S":
                        onSumRequested();
                        break;
                    case "M":
                        onAverageRequested();
                        break;
                    case "E":
                        return;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        internal static decimal Sum(IEnumerable<decimal> data)
        {
            return data.Sum();
        }

        public static void WriteResult(string method, decimal result)
        {
            Console.WriteLine($"{method}: {result}");
        }

        public static decimal Average(IEnumerable<decimal> data)
        {
            return data.Average();
        }
    }
}