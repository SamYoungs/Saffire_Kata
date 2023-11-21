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
        public void Given2ReturnAnII()
        {
            var romanNumeral = new RomanNumeral();

            string result = romanNumeral.Convert(2);

            Assert.IsTrue("II" == result);
        }

        [Test]
        public void Given3ReturnAnIII()
        {
            var romanNumeral = new RomanNumeral();

            string result = romanNumeral.Convert(3);

            Assert.IsTrue("III" == result);
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