using Model;

namespace Test
{
    public class RomanNumeralsTests
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(14, "XIV")]
        [TestCase(15, "XV")]
        [TestCase(19, "XIX")]
        [TestCase(20, "XX")]
        [TestCase(24, "XXIV")]
        [TestCase(25, "XXV")]
        [TestCase(29, "XXIX")]
        [TestCase(30, "XXX")]
        [TestCase(34, "XXXIV")]
        [TestCase(35, "XXXV")]
        [TestCase(39, "XXXIX")]
        [TestCase(40, "XL")]
        [TestCase(50, "L")]
        [TestCase(54, "LIV")]
        [TestCase(55, "LV")]
        [TestCase(59, "LIX")]
        [TestCase(90, "XC")]
        [TestCase(94, "XCIV")]
        [TestCase(95, "XCV")]
        [TestCase(99, "XCIX")]
        [TestCase(100, "C")]
        [TestCase(123, "CXXIII")]
        [TestCase(295, "CCXCV")]
        [TestCase(399, "CCCXCIX")]
        [TestCase(400, "CD")]
        [TestCase(464, "CDLXIV")]
        [TestCase(478, "CDLXXVIII")]
        [TestCase(500, "D")]
        [TestCase(755, "DCCLV")]
        [TestCase(900, "CM")]
        [TestCase(949, "CMXLIX")]
        [TestCase(1000, "M")]
        [TestCase(1111, "MCXI")]
        [TestCase(2377, "MMCCCLXXVII")]
        [TestCase(2992, "MMCMXCII")]
        [TestCase(3000, "MMM")]
        public void GivenAnIntReturnARomanNumeral(int value, string expectedResult)
        {
            var romanNumeral = new RomanNumeral();

            string result = romanNumeral.Convert(value);

            Assert.IsTrue(result == expectedResult);
        }

        [Test]
        public void GivenAZeroExpectedAnExpection()
        {
            Assert.Throws(typeof(ArgumentOutOfRangeException), () => new RomanNumeral().Convert(0));
        }

        [Test]
        public void GivenANumberGreaterThan3000ExpectedAnExpection()
        {
            Assert.Throws(typeof(ArgumentOutOfRangeException), () => new RomanNumeral().Convert(3001));
        }
    }
}