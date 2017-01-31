using System.Collections.Generic;

namespace Auswerten
{
    public class Program
    {
        static void Main(string[] args)
        {
            var data = Analyzer.ReadData();
            Analyzer.AskAnalysisMethod(
                () =>
                {
                    var sum = Analyzer.Sum(data);
                    Analyzer.WriteResult("Summe", sum);
                }, 
                () => DoAverage(data));
        }

        static void DoAverage(IEnumerable<decimal> data)
        {
            var result = Analyzer.Average(data);
            Analyzer.WriteResult("Mittelwert", result);
        }
    }
}
