using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiSample;
using ApiSample.Controllers;

namespace UnitTestRaktar
{
    public class TermekControllerTest
    {
        [Test,
            TestCase("krw", false),
            TestCase("KWRT", false),
            TestCase("k23l", false),
            TestCase("234Lpt", false),
            TestCase("23", true)
             ]

        public void TestQuantity(string mennyiseg, bool expectedResult)
        {
            //Arrange
            var termekcontroller = new TermekController();

            // Act
            var actualResult = termekcontroller.IsInteger(mennyiseg);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }




        [Test,
            TestCase("krw", "jhbch", false),
            TestCase("ltWs", "dnivcdv", false),
            TestCase("WWW", "KRW", false),
            TestCase("W", "KRW", true),
            TestCase("kr", "krw", true),
            TestCase("KR", "krw", true),
            TestCase("krw", "krw", true),
            TestCase("krw", "Krw", true),
            TestCase("krw", "KRW", true)
             ]

        public void TestMatchesItems(string tb_szoveg, string lb_szoveg, bool expectedResult)
        {
            //Arrange
            var termekcontroller = new TermekController();

            // Act
            var actualResult = termekcontroller.MatchesItemList(tb_szoveg, lb_szoveg);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }


        [Test,
            TestCase("1", "1", false),
            TestCase("3", "2", true),
            TestCase("3", "4", true),
            TestCase("3", "25", true),
            TestCase("3", "0", true)
             ]
        public void TestOriginalValue(int eredeti, int uj, bool expectedResult)
        {
            //Arrange
            var termekcontroller = new TermekController();

            // Act
            var actualResult = termekcontroller.RestoresOriginalValue(eredeti, uj);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

    }


}












//    [TestFixture]
//    public class DataProcessorTests
//    {
//        private DataProcessor processor;
//        private List<string> itemList;

//        [SetUp]
//        public void Setup()
//        {
//            processor = new DataProcessor();
//            itemList = new List<string> { "Product1", "Product2", "Product3" };
//        }

//        [Test]
//        public void Test_IsInteger()
//        {
//            // Arrange
//            string validInteger = "123";
//            string invalidInteger = "abc";

//            // Act & Assert
//            Assert.IsTrue(processor.IsInteger(validInteger));
//            Assert.IsFalse(processor.IsInteger(invalidInteger));
//        }

//        [Test]
//        public void Test_MatchesItemList()
//        {
//            // Arrange
//            string searchItem = "";

//            // Act & Assert
//            if (string.IsNullOrEmpty(searchItem))
//            {

//                Assert.IsTrue(true);
//            }
//            else
//            {

//                Assert.IsTrue(itemList.Any(item => item.Contains(searchItem, StringComparison.OrdinalIgnoreCase)),
//                    $"No item in the list contains '{searchItem}' (ignoring case).");
//            }
//            //Assert.IsTrue(itemList.Any(item => item.Contains(searchItem, StringComparison.OrdinalIgnoreCase)));

//        }

//        [Test]
//        public void Test_RestoresOriginalValue()
//        {
//            // Arrange
//            string originalValue = "OriginalValue";
//            string modifiedValue = "NewValue";

//            // Act
//            string restoredValue = processor.RestoreValue(originalValue, modifiedValue);

//            // Assert
//            Assert.AreEqual(originalValue, restoredValue);
//        }
//    }

//    public class DataProcessor
//    {
//        public bool IsInteger(string value)
//        {
//            return int.TryParse(value, out _);
//        }

//        public string RestoreValue(string originalValue, string modifiedValue)
//        {

//            return originalValue;
//        }
//    }


//}