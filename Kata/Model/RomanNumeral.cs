namespace Model
{
    public class RomanNumeral
    {
        public string Convert(int value)
        {
            if(value == 1)
            {
                return "I";
            }
            else
            {
                return "V";
            }
            
        }
    }
}