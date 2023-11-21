namespace Model
{
    public class RomanNumeral
    {
        private readonly Dictionary<int, string> romanNumeralsDictionary = new Dictionary<int, string>
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

        public string Convert(int value)
        {
            if (value < 1 || value > 3000)
            {
                throw new ArgumentOutOfRangeException();
            }

            string romanNumerals = string.Empty;

            foreach(var (key, romanNumeral) in romanNumeralsDictionary)
            {
                while (value >= key)
                {
                    romanNumerals += romanNumeral;
                    value -= key;
                }
            }

            return romanNumerals;
        }
    }
}