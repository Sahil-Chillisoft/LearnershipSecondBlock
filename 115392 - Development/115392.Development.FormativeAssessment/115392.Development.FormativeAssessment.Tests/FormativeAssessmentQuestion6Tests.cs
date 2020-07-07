using System;
using NUnit.Framework;

namespace _115392.Development.FormativeAssessment.Tests
{
    [TestFixture]
    public class FormativeAssessmentQuestion6Tests
    {
        public FormativeAssessment FormativeAssessment()
        {
            return new FormativeAssessment();
        }

        [Test]
        public void Calculate_Given2Numbers_ReturnAddition()
        {
            //Arrange 
            const int num1 = 125;
            const int num2 = 24;
            const int expectedOutput = 149;

            //Act             
            var output = FormativeAssessment().Add(num1, num2);

            //Assert
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void Calculate_Given2Numbers_ReturnSubtraction()
        {
            //Arrange 
            const int num1 = 125;
            const int num2 = 24;
            const int expectedOutput = 101;

            //Act             
            var output = FormativeAssessment().Subtract(num1, num2);

            //Assert
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void Calculate_Given2Numbers_ReturnMultiplication()
        {
            //Arrange 
            const int num1 = 125;
            const int num2 = 24;
            const int expectedOutput = 3000;

            //Act             
            var output = FormativeAssessment().Multiply(num1, num2);

            //Assert
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void Calculate_Given2Numbers_ReturnDivision()
        {
            //Arrange 
            const int num1 = 125;
            const int num2 = 24;
            const int expectedOutput = 5;

            //Act             
            var output = FormativeAssessment().Divide(num1, num2);

            //Assert
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void Calculate_Given2Numbers_ReturnRemainder()
        {
            //Arrange 
            const int num1 = 125;
            const int num2 = 24;
            const int expectedOutput = 5;

            //Act             
            var output = FormativeAssessment().Remainder(num1, num2);

            //Assert
            Assert.AreEqual(expectedOutput, output);
        }
    }
}
