namespace RomanNumeralsHelper
{
    public class NumeralToRomanNumeralConverter: IConverter
    {
        private readonly Dictionary<string, int> romanNumeralAlphabet = new Dictionary<string, int>
        {
            { "M", 1000 }, { "D", 500 }, { "C", 100 }, { "L", 50 }, { "X", 10 }, { "IX", 9 }, { "VIII", 8 }, { "VII", 7 }, { "VI", 6 }, { "V", 5 },
            { "IV", 4 },{ "III", 3 },{ "II", 2 },{ "I", 1 }
        };

        public string Convert(int n)
        {
            var romanNumeralString = "";

            foreach(var liter in romanNumeralAlphabet)
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
