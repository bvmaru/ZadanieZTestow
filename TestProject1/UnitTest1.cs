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
        public void PotwierdzaLiczbyPierwsze(string input, string expected)
        {
            var sut = new LiczbyPierwsze();
            string res = sut.Sprawdzenie(input);
            Assert.AreEqual(expected, res);
        }

        [TestCase("4", "Liczba nie jest liczba pierwsza")]
        [TestCase("6", "Liczba nie jest liczba pierwsza")]
        [TestCase("12", "Liczba nie jest liczba pierwsza")]
        public void PotwierdzaLiczbyNiepierwsze(string input, string expected)
        {
            var sut = new LiczbyPierwsze();
            string res = sut.Sprawdzenie(input);
            Assert.AreEqual(expected, res);
        }

        [TestCase("4", "Liczba jest liczba pierwsza")]
        [TestCase("6", "Liczba jest liczba pierwsza")]
        [TestCase("12", "Liczba jest liczba pierwsza")]
        public void NiePotwierdzaLiczbNiepierwszych(string input, string expected)
        {
            var sut = new LiczbyPierwsze();
            string res = sut.Sprawdzenie(input);
            Assert.AreNotEqual(expected, res);
        }

        [TestCase("-1")]
        [TestCase("-112")]
        public void WyrzucaBladPrzyUjemnychWartosciach(string input)
        {
            var sut = new LiczbyPierwsze();
            Assert.Throws<InvalidOperationException>(() => sut.Sprawdzenie(input));
        }

        [TestCase("q")]
        [TestCase("slowo")]
        public void WyrzucaBladPrzyNieLiczbach(string input)
        {
            var sut = new LiczbyPierwsze();
            Assert.Throws<InvalidOperationException>(() => sut.Sprawdzenie(input));
        }

        [TestCase("1.5")]
        [TestCase("22.7")]
        public void WyrzucaBladPrzyWartosciachZmiennoPrzecinkowych(string input)
        {
            var sut = new LiczbyPierwsze();
            Assert.Throws<InvalidOperationException>(() => sut.Sprawdzenie(input));
        }

        [TestCase("0", "Liczba nie jest liczba pierwsza")]
        [TestCase("1", "Liczba nie jest liczba pierwsza")]
        public void PrzypadkiSkrajne(string input, string expected)
        {
            var sut = new LiczbyPierwsze();
            string res = sut.Sprawdzenie(input);
            Assert.AreEqual(expected, res);
        }


    }
}