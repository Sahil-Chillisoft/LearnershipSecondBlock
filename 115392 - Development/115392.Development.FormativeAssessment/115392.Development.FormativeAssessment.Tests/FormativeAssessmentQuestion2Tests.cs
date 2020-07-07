using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace _115392.Development.FormativeAssessment.Tests
{
    [TestFixture]
    public class FormativeAssessmentQuestion2Tests
    {
        public FormativeAssessment FormativeAssessment()
        {
            return new FormativeAssessment();
        }

        [Test]
        public void ConvertMeasurement_GivenInch_ReturnMeter()
        {
            //Arrange 
            const double input = 1000;
            const double expectedOutput = 25.4;

            //Act             
            var output = FormativeAssessment().ConvertInchesToMeters(input);

            //Assert
            Assert.AreEqual(expectedOutput, output);
        }
    }
}
