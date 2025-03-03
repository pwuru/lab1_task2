using Microsoft.VisualStudio.TestTools.UnitTesting;
using tech_lab1_task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tech_lab1_task2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void NumberOfNumbers4OrMoreTest()
        {
            var numbers = new List<double>() { 12, 23, 34, -56, -3438, 0, 3181, 934, -93 };
            double[] testResult = [3181, 934, -3438, -93];

            var result = Logic.Search(numbers);

            Assert.AreEqual(testResult[0], result[0]);
            Assert.AreEqual(testResult[1], result[1]);
            Assert.AreEqual(testResult[2], result[2]);
            Assert.AreEqual(testResult[3], result[3]);
        }
        
        [TestMethod()]
        public void NumberOfNumbersLessThan4Test()
        {
            var numbers = new List<double>() { 12, 23, -56 };
            double[] testResult = [3181, 934, -3438, -93];

            var result = Logic.Search(numbers);

            Assert.AreEqual(null, result);
        }
    }
}