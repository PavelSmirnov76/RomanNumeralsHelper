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

        [Fact]
        public void Convert_8_VIII()
        {
            var number = 8;
            var expected = "VIII";

            var actual = new NumeralToRomanNumeralConverter().Convert(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_7_VII()
        {
            var number = 7;
            var expected = "VII";

            var actual = new NumeralToRomanNumeralConverter().Convert(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_6_VI()
        {
            var number = 6;
            var expected = "VI";

            var actual = new NumeralToRomanNumeralConverter().Convert(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_5_V()
        {
            var number = 5;
            var expected = "V";

            var actual = new NumeralToRomanNumeralConverter().Convert(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_4_IV()
        {
            var number = 4;
            var expected = "IV";

            var actual = new NumeralToRomanNumeralConverter().Convert(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_3_III()
        {
            var number = 3;
            var expected = "III";

            var actual = new NumeralToRomanNumeralConverter().Convert(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_2_II()
        {
            var number = 2;
            var expected = "II";

            var actual = new NumeralToRomanNumeralConverter().Convert(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_1_I()
        {
            var number = 1;
            var expected = "I";

            var actual = new NumeralToRomanNumeralConverter().Convert(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_1666_MDCLXVI()
        {
            var number = 1666;
            var expected = "MDCLXVI";

            var actual = new NumeralToRomanNumeralConverter().Convert(number);

            Assert.Equal(expected, actual);
        }
    }
}