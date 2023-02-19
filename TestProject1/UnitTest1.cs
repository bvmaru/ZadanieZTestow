using ZadanieZTestow;

namespace TestProject1

{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("3", "Liczba jest liczba pierwsza")]
        [TestCase("5", "Liczba jest liczba pierwsza")]
        [TestCase("11", "Liczba jest liczba pierwsza")]
        public void PierwszyTest(string input, string expected)
        {
            var sut = new LiczbyPierwsze();
            string res = sut.Sprawdzenie(input);
            Assert.AreEqual(expected, res);
        }

        [TestCase("4", "Liczba jest liczba pierwsza")]
        [TestCase("6", "Liczba jest liczba pierwsza")]
        [TestCase("12", "Liczba jest liczba pierwsza")]
        public void DrugiTest(string input, string expected)
        {
            var sut = new LiczbyPierwsze();
            string res = sut.Sprawdzenie(input);
            Assert.AreNotEqual(expected, res);
        }

        [TestCase("-1", "Liczba nie jest liczba pierwsza")]
        [TestCase("-112", "Liczba nie jest liczba pierwsza")]
        public void TrzeciTest(string input, string expected)
        {
            var sut = new LiczbyPierwsze();
            Assert.Throws<InvalidOperationException>(() => sut.Sprawdzenie(input));
        }
    }
}