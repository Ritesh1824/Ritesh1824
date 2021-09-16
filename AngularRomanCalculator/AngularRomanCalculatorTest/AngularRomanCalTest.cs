using AngularRomanCalculator.Controllers;
using AngularRomanCalculator.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AngularRomanCalculatorTest
{
    [TestClass]
    public class AngularRomanCalTest
    {
        RomanCalHelper romanCalHelper = new RomanCalHelper();
        DecimalCalHelper decimalCalHelper = new DecimalCalHelper();
        RomanCalController romanCalController = new RomanCalController();
        DecimalCalController decimalCalController = new DecimalCalController();
        [TestMethod]
        public void Test_AddDeciaml_ForInt()
        {          
            string excepted = "17";
            int num1 = 11;
            int num2 = 6;
         
            string actual = decimalCalHelper.addDeciaml(num1,num2);           
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Test_AddDeciaml_ForDecimal()
        {
            string excepted = "27.2";
            double num1 = 20.5;
            double num2 = 6.7;

            string actual = decimalCalHelper.addDeciaml(num1, num2);
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Test_IntToRoman()
        {
            string excepted = "XV";
            int num = 15;

            string actual = romanCalHelper.intToRoman(num);
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void Test_RomanToInt()
        {
            int excepted = 15;
            string num = "XV";

            int actual = romanCalHelper.romanToInt(num);
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void Test_addRoman()
        {
            string excepted = "XXIX";
            string num1 = "XV";
            string num2 = "XIV";

            string actual = romanCalHelper.addRoman(num1,num2);
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Test_addRoman_ExceedsRange()
        {
            string excepted = "Error:Range Exceeded, Final Result should be <= MMMCMXCIX(3999)";
            string num1 = "MMM";
            string num2 = "M";

            string actual = romanCalHelper.addRoman(num1, num2);
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Test_RomanCalController()
        {
            string excepted = "XV";
            string num1 = "V";
            string num2 = "X";

            string actual = romanCalController.addRomanNum(num1,num2).Value;
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Test_DecimalCalController()
        {
            string excepted = "19";
            string num1 = "5";
            string num2 = "14";

            string actual = decimalCalController.addDecimalNum(num1, num2).Value;
            Assert.AreEqual(excepted, actual);
        }
    }
}
