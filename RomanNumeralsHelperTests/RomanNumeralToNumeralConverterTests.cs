namespace RomanNumeralsHelperTests
{
    public class RomanNumeralToNumeralConverterTests
    {
        [Fact]
        public void Convert_MMM_3000()
        {
            var romanNumeral = "MMM";
            var expected = 3000;

            var actual = RomanNumeralToNumeralConverter.Convert(romanNumeral);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_M_1000()
        {
            var romanNumeral = "M";
            var expected = 1000;

            var actual = RomanNumeralToNumeralConverter.Convert(romanNumeral);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_D_500()
        {
            var romanNumeral = "D";
            var expected = 500;

            var actual = RomanNumeralToNumeralConverter.Convert(romanNumeral);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_C_100()
        {
            var romanNumeral = "C";
            var expected = 100;

            var actual = RomanNumeralToNumeralConverter.Convert(romanNumeral);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_L_50()
        {
            var romanNumeral = "L";
            var expected = 50;

            var actual = RomanNumeralToNumeralConverter.Convert(romanNumeral);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_X_50()
        {
            var romanNumeral = "X";
            var expected = 10;

            var actual = RomanNumeralToNumeralConverter.Convert(romanNumeral);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_V_5()
        {
            var romanNumeral = "V";
            var expected = 5;

            var actual = RomanNumeralToNumeralConverter.Convert(romanNumeral);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_CD_400()
        {
            var romanNumeral = "CD";
            var expected = 400;

            var actual = RomanNumeralToNumeralConverter.Convert(romanNumeral);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Convert_XLIV_44()
        {
            var romanNumeral = "XLIV";
            var expected = 44;

            var actual = RomanNumeralToNumeralConverter.Convert(romanNumeral);

            Assert.Equal(expected, actual);
        }
    }
}
