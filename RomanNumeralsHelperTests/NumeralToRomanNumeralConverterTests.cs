namespace RomanNumeralsHelperTests
{
    public class NumeralToRomanNumeralConverterTests
    {
        [Fact]
        public void Convert_3000_MMM()
        {
            var number = 3000;
            var expected = "MMM";

            var actual = new NumeralToRomanNumeralConverter().Convert(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_1000_M()
        {
            var number = 1000;
            var expected = "M";

            var actual = new NumeralToRomanNumeralConverter().Convert(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_500_D()
        {
            var number = 500;
            var expected = "D";

            var actual = new NumeralToRomanNumeralConverter().Convert(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_100_C()
        {
            var number = 100;
            var expected = "C";

            var actual = new NumeralToRomanNumeralConverter().Convert(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_50_L()
        {
            var number = 50;
            var expected = "L";

            var actual = new NumeralToRomanNumeralConverter().Convert(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_10_X()
        {
            var number = 10;
            var expected = "X";

            var actual = new NumeralToRomanNumeralConverter().Convert(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_9_IX()
        {
            var number = 9;
            var expected = "IX";

            var actual = new NumeralToRomanNumeralConverter().Convert(number);

            Assert.Equal(expected, actual);
        }
    }
}