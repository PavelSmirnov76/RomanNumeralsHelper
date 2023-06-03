namespace RomanNumeralsHelper
{
    public class RomanNumeralToNumeralConverter
    {
        public static int Convert(string romanNumeral)
        {
            int n = 0;

            for(int i = 0; i < romanNumeral.Length; i++)
            {
                if (i + 1 < romanNumeral.Length && 
                    RomanNumeralAlphabet.romanNumeralAlphabet[romanNumeral[i].ToString()] < RomanNumeralAlphabet.romanNumeralAlphabet[romanNumeral[i + 1].ToString()])
                {
                    n -= RomanNumeralAlphabet.romanNumeralAlphabet[romanNumeral[i].ToString()];
                }
                else
                {
                    n += RomanNumeralAlphabet.romanNumeralAlphabet[romanNumeral[i].ToString()];
                }
            }

            return n;
        }
    }
}
