using Model;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        [Test]
        public void GivenA1ReturnAnI()
        {
            var romanNumeral = new RomanNumeral();
            
            string result = romanNumeral.Convert(1);
            
            Assert.AreEqual("I", result);
        }
    }
}