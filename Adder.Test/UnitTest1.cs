using NUnit.Framework;
using System.Collections.Generic;
using Adder;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            AdderLogic adderLogic = new AdderLogic();
                adderLogic.NumberList = new List<int>(new int[] {1, 2, 3, 4, 5 });
        }

        [Test]
        public void AdderreturnsExpectedValue()
        {
            string ExpectedValue = "20";


            AdderLogic aResultrLogic = new AdderLogic();
            var result = aResultrLogic.Add("20");

            Assert.AreEqual(ExpectedValue, result);
        }
    }
}