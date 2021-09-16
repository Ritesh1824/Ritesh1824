using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AngularRomanCalculatorTest
{
    [TestClass]
    class RomanCalHelperTest
    {
        [TestMethod]
        public void Test_IntToRoman()
        {
            string excepted = "XIV";
            int num = 15;
          
            string actual = AngularRomanCalculator.Models.RomanCalHelper.intToRoman(num);
            Assert.AreEqual(excepted, actual);
        }
    }
}
