using NUnit.Framework;

namespace Auswerten
{
    [TestFixture]
    public class AnalyzerTest
    {
        [Test]
        public void TestReadData()
        {
            var actual = Analyzer.ReadData();
            var expected = new[] {10.5m, 20.75m, 30};
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSum()
        {
            var input = new[] { 10.5m, 20.75m, 30 };
            var expected = 61.25m;
            var actual = Analyzer.Sum(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestAverage()
        {
            var input = new[] { 10.5m, 20.75m, 30 };
            var expected = 20.416m;
            var actual = Analyzer.Average(input);
            Assert.AreEqual((double)expected, (double)actual, 0.01);
        }
    }
}
