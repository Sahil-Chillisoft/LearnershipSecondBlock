using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace _115392.Development.FormativeAssessment.Tests
{
    [TestFixture]
    public class FormativeAssessmentQuestion1Tests
    {
        public FormativeAssessment FormativeAssessment()
        {
            return new FormativeAssessment();
        }

        [Test]
        public void ConvertTemperature_GivenFahrenheit_ReturnCelsius()
        {
            //Arrange 
            const int input = 212;
            const int expectedOutput = 100;

            //Act            
            var output = FormativeAssessment().ConvertFahrenheitToCelsius(input);

            //Assert
            Assert.AreEqual(expectedOutput, output);
        }
    }
}
