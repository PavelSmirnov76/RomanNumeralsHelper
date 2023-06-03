namespace RomanNumeralsHelper
{
    public class NumeralToRomanNumeralConverter
    {
        public static string Convert(int n)
        {
    
            var romanNumeralString = "";

            foreach(var liter in RomanNumeralAlphabet.romanNumeralAlphabet)
            {
                romanNumeralString += PickOutOneRomanNumber(n, liter.Value, liter.Key);
                n %= liter.Value;
            }

            return romanNumeralString;
        }

        private static string PickOutOneRomanNumber(int n, int costRomanNumber, string literalRomanNumber)
        {
            var romanNumberCount = n / costRomanNumber;

            var romanNumeralString = "";

            for (int i = 0; i < romanNumberCount; i++)
            {
                romanNumeralString += literalRomanNumber;
            }

            return romanNumeralString;
        }
    }
}
