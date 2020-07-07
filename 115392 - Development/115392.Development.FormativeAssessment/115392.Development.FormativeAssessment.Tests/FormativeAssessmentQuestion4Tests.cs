using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace _115392.Development.FormativeAssessment.Tests
{
    public class FormativeAssessmentQuestion4Tests
    {
        public FormativeAssessment FormativeAssessment()
        {
            return new FormativeAssessment();
        }

        private const float Meters = 2500;
        private const float Hour = 5;
        private const float Minutes = 56;
        private const float Seconds = 23;

        [Test]
        public void CalculateDistance_GivenMetersHoursMinutesSeconds_ReturnMetersPerSecond()
        {
            //Arrange 
            const float expectedOutput = 0.11691531f;

            //Act             
            var output = FormativeAssessment().CalculateMetersPerSecond(Meters, Hour, Minutes, Seconds);

            //Assert
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void CalculateDistance_GivenMetersHoursMinutesSeconds_ReturnKilometersPerHour()
        {
            //Arrange 
            const float expectedOutput = 0.42089513f;

            //Act             
            var output = FormativeAssessment().CalculateKilometersPerHour(Meters, Hour, Minutes, Seconds);

            //Assert
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void CalculateDistance_GivenMetersHoursMinutesSeconds_ReturnMilesPerHour()
        {
            //Arrange 
            const float expectedOutput = 0.26158804f;

            //Act             
            var output = FormativeAssessment().CalculateMilesPerHour(Meters, Hour, Minutes, Seconds);

            //Assert
            Assert.AreEqual(expectedOutput, output);
        }
    }
}
