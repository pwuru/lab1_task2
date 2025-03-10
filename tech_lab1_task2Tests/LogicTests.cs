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
        public void NotSameNumbersTest()
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

            var result = Logic.Search(numbers);

            Assert.AreEqual(null, result);
        }

        [TestMethod()]
        public void AllSameNumbersTest()
        {
            var numbers = new List<double>() { 53, 53, 53, 53, 53 };
            double[] testResult = [53, 53, 53, 53];

            var result = Logic.Search(numbers);

            Assert.AreEqual(testResult[0], result[0]);
            Assert.AreEqual(testResult[1], result[1]);
            Assert.AreEqual(testResult[2], result[2]);
            Assert.AreEqual(testResult[3], result[3]);
        }

        [TestMethod()]
        public void Big3SameNumbersTest()
        {
            var numbers = new List<double>() { 53, 21, 53, 53 };
            double[] testResult = [53, 53, 21, 53];

            var result = Logic.Search(numbers);

            Assert.AreEqual(testResult[0], result[0]);
            Assert.AreEqual(testResult[1], result[1]);
            Assert.AreEqual(testResult[2], result[2]);
            Assert.AreEqual(testResult[3], result[3]);
        }

        [TestMethod()]
        public void Small3SameNumbersTest()
        {
            var numbers = new List<double>() { 21, 21, 53, 21 };
            double[] testResult = [53, 21, 21, 21];

            var result = Logic.Search(numbers);

            Assert.AreEqual(testResult[0], result[0]);
            Assert.AreEqual(testResult[1], result[1]);
            Assert.AreEqual(testResult[2], result[2]);
            Assert.AreEqual(testResult[3], result[3]);
        }

        [TestMethod()]
        public void Small2SameNumbersTest()
        {
            var numbers = new List<double>() { 21, 21, 53, 41, 32 };
            double[] testResult = [53, 41, 21, 21];

            var result = Logic.Search(numbers);

            Assert.AreEqual(testResult[0], result[0]);
            Assert.AreEqual(testResult[1], result[1]);
            Assert.AreEqual(testResult[2], result[2]);
            Assert.AreEqual(testResult[3], result[3]);
        }

        [TestMethod()]
        public void Big2SameNumbersTest()
        {
            var numbers = new List<double>() { 53, 21, 53, 41, 32 };
            double[] testResult = [53, 53, 21, 32];

            var result = Logic.Search(numbers);

            Assert.AreEqual(testResult[0], result[0]);
            Assert.AreEqual(testResult[1], result[1]);
            Assert.AreEqual(testResult[2], result[2]);
            Assert.AreEqual(testResult[3], result[3]);
        }

        [TestMethod()]
        public void Same1BigAnd1SmallNumbersTest()
        {
            var numbers = new List<double>() { 15, 21, 21, 32 };
            double[] testResult = [32, 21, 15, 21];

            var result = Logic.Search(numbers);

            Assert.AreEqual(testResult[0], result[0]);
            Assert.AreEqual(testResult[1], result[1]);
            Assert.AreEqual(testResult[2], result[2]);
            Assert.AreEqual(testResult[3], result[3]);
        }

        [TestMethod()]
        public void Same2BigAndSame2SmallNumbersTest()
        {
            var numbers = new List<double>() { 15, 15, 32, 32 };
            double[] testResult = [32, 32, 15, 15];

            var result = Logic.Search(numbers);

            Assert.AreEqual(testResult[0], result[0]);
            Assert.AreEqual(testResult[1], result[1]);
            Assert.AreEqual(testResult[2], result[2]);
            Assert.AreEqual(testResult[3], result[3]);
        }
    }
}