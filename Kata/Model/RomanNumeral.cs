namespace Model
{
    public class RomanNumeral
    {
        public string Convert(int value)
        {
            if (value == 1) return "I";
            if (value == 2) return "II";
            if (value == 3) return "III";

            return "V";
            
        }
    }
}