using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD2;

namespace TDD2Testy
{
    
        [TestClass]
        public class CalculatorTests
        {
            [TestMethod]
            public void TestEmpty()
            {
                //Given
                var input = "";
                var expected = 0;
                //When
                var result = Calculator.Calculate(input);

                //Then
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void OneNumberTest()
            {
                //Given
                var input = "2";
                int expected = 2;
                //When
                var result = Calculator.Calculate(input);

                //Then
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void CommaDelimitedTest()
            {
                //Given
                var input = "3,2";
                int expected = 5;
                //When
                var result = Calculator.Calculate(input);

                //Then
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void NewLineDelimitedTest()
            {
                //Given
                var input = "2\n4";
                int expected = 6;
                //When
                var result = Calculator.Calculate(input);

                //Then
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void ThreeNumbersTest()
            {
                //Given
                var input = "1\n1,7";
                int expected = 9;
                //When
                var result = Calculator.Calculate(input);

                //Then
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException), "Input should not be negative")]
            public void NegativeNumbersTest()
            {
                //Given
                var input = "-2\n4,9";

                //When
                var result = Calculator.Calculate(input);
            }

            [TestMethod]
            public void Morethan1000Test()
            {
                //Given
                var input = "2\n3,1001";
                int expected = 5;
                //When
                var result = Calculator.Calculate(input);

                //Then
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void DelimiterAtBeginningTest()
            {
                //Given
                var input = "#2\n7,1001";
                int expected = 9;
                //input
                var result = Calculator.Calculate(input);

                //Then
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void ManyDelimsAtBeginningTest()
            {
                //Given
                var input = "####4\n7,1001";
                int expected = 11;
                //When
                var result = Calculator.Calculate(input);

                //Then
                Assert.AreEqual(expected, result);
                
            }
        }
    }


