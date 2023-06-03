namespace RomanNumeralsHelper
{
    public class NumeralToRomanNumeralConverter: IConverter
    {
        private const int COST_M = 1000;
        private const string LITER_M = "M";
        private const int COST_D = 500;
        private const string LITER_D = "D";
        private const int COST_C = 100;
        private const string LITER_C = "C";
        private const int COST_L = 50;
        private const string LITER_L = "L";
        private const int COST_X = 10;
        private const string LITER_X = "X";
        private const int COST_IX = 9;
        private const string LITER_IX = "IX";
        public string Convert(int n)
        {
            var romanNumeralString = "";

            romanNumeralString += PickOutOneRomanNumber(n, COST_M, LITER_M);
            n = n % COST_M;
            romanNumeralString += PickOutOneRomanNumber(n, COST_D, LITER_D);
            n = n % COST_D;
            romanNumeralString += PickOutOneRomanNumber(n, COST_C, LITER_C);
            n = n % COST_C;
            romanNumeralString += PickOutOneRomanNumber(n, COST_L, LITER_L);
            n = n % COST_L;
            romanNumeralString += PickOutOneRomanNumber(n, COST_X, LITER_X);
            n = n % COST_X;
            romanNumeralString += PickOutOneRomanNumber(n, COST_IX, LITER_IX);
            n = n % COST_IX;

            return romanNumeralString;
        }

        private string PickOutOneRomanNumber(int n, int costRomanNumber, string literalRomanNumber)
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
