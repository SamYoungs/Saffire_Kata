using Model;

namespace Test
{
    public class RomanNumeralsTests
    {
        [Test]
        public void GivenA1ReturnAnI()
        {
            var romanNumeral = new RomanNumeral();

            string result = romanNumeral.Convert(1);

            Assert.IsTrue("I" == result);
        }

        [Test]
        public void GivenA5ReturnAnV()
        {
            var romanNumeral = new RomanNumeral();

            string result = romanNumeral.Convert(5);

            Assert.IsTrue("V" == result);
        }
    }
}