using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AngularRomanCalculatorTest
{
    [TestClass]
    public class DecimalCalHelperTest
    {
        [TestMethod]
        public void Test_AddDeciaml_ForInt()
        {          
            string excepted = "17";
            int num1 = 11;
            int num2 = 6;
         
            string actual = AngularRomanCalculator.Models.DecimalCalHelper.addDeciaml(num1,num2);           
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Test_AddDeciaml_ForDecimal()
        {
            string excepted = "27.2";
            double num1 = 20.5;
            double num2 = 6.7;

            string actual = AngularRomanCalculator.Models.DecimalCalHelper.addDeciaml(num1, num2);
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Test_IntToRoman()
        {
            string excepted = "XV";
            int num = 15;

            string actual = AngularRomanCalculator.Models.RomanCalHelper.intToRoman(num);
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void Test_RomanToInt()
        {
            int excepted = 15;
            string num = "XV";

            int actual = AngularRomanCalculator.Models.RomanCalHelper.romanToInt(num);
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void Test_addRoman()
        {
            string excepted = "XXIX";
            string num1 = "XV";
            string num2 = "XIV";

            string actual = AngularRomanCalculator.Models.RomanCalHelper.addRoman(num1,num2);
            Assert.AreEqual(excepted, actual);
        }
    }
}
