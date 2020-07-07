using System;

namespace _115392.Development.FormativeAssessment
{
    public class FormativeAssessment
    {
        public static void Main(string[] args)
        {
            ExecuteFormativeAssessment();
        }

        #region ExecuteFormativeAssessment
        private static void ExecuteFormativeAssessment()
        {
            var formativeAssessment = new FormativeAssessment();
            Console.WriteLine("Options: \n0 - Exit \n1 - Question 1 \n2 - Question 2 \n3 - Question 3 \n4 - Question 4 \n5 - Question 5 \n6 - Question 6 \n\nEnter exercise option to execute: ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    formativeAssessment.Question1();
                    break;
                case "2":
                    formativeAssessment.Question2();
                    break;
                case "3":
                    formativeAssessment.Question3();
                    break;
                case "4":
                    formativeAssessment.Question4();
                    break;
                case "5":
                    formativeAssessment.Question5();
                    break;
                case "6":
                    formativeAssessment.Question6();
                    break;
                default:
                    Console.WriteLine("\nInvalid option, please try again.\n");
                    ExecuteFormativeAssessment();
                    break;
            }
        }
        #endregion

        #region Question1
        public void Question1()
        {
            Console.WriteLine("Input a degree in Fahrenheit:");
            var input = Console.ReadLine();
            try
            {
                var output = ConvertFahrenheitToCelsius(int.Parse(input));
                Console.WriteLine($"{input} degree Fahrenheit is equal to {output} in Celsius.");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input.\n");
                Question1();
            }
        }

        public int ConvertFahrenheitToCelsius(int fahrenheit)
        {
            var celsiusConversionCalculation = (fahrenheit - 32) * 5 / 9;
            return celsiusConversionCalculation;
        }
        #endregion

        #region Question2
        public void Question2()
        {
            Console.WriteLine("Input a value for inch:");
            var inchInput = Console.ReadLine();
            try
            {
                var meter = ConvertInchesToMeters(double.Parse(inchInput));
                Console.WriteLine($"{inchInput} inch is {meter} meters ");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input.\n");
                Question2();
            }
        }

        public double ConvertInchesToMeters(double inches)
        {
            const double conversionBase = 0.0254;
            var inchesToMetersCalculation = inches * conversionBase;
            return inchesToMetersCalculation;
        }
        #endregion

        #region Question3
        public void Question3()
        {
            var currentDateTime = DateTime.UtcNow;
            Console.WriteLine(currentDateTime);
        }

        #endregion

        #region Question4
        public void Question4()
        {
            try
            {
                Console.WriteLine("Input distance in meters:");
                var meters = float.Parse(Console.ReadLine());

                Console.WriteLine("\nInput hour:");
                var hour = float.Parse(Console.ReadLine());

                Console.WriteLine("\nInput minutes:");
                var minutes = float.Parse(Console.ReadLine());

                Console.WriteLine("\nInput seconds:");
                var seconds = float.Parse(Console.ReadLine());

                var metersPerSecond = CalculateMetersPerSecond(meters, hour, minutes, seconds);
                var kilometersPerHour = CalculateKilometersPerHour(meters, hour, minutes, seconds);
                var milesPerHour = CalculateMilesPerHour(meters, hour, minutes, seconds);

                Console.WriteLine($"\nYour speed in meters/second is: {metersPerSecond}");
                Console.WriteLine($"Your speed in km/h is: {kilometersPerHour}");
                Console.WriteLine($"Your speed in miles/h is: {milesPerHour}");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input supplied for one of the options, please retry.\n");
                Question4();
            }
        }

        public float CalculateMetersPerSecond(float meters, float hour, float minutes, float seconds)
        {
            var timeSeconds = (hour * 3600) + (minutes * 60) + seconds;
            var metersPerSecond = meters / timeSeconds;
            return metersPerSecond;
        }

        public float CalculateKilometersPerHour(float meters, float hour, float minutes, float seconds)
        {
            var timeSeconds = (hour * 3600) + (minutes * 60) + seconds;
            var kilometersPerHour = (meters / 1000.0f) / (timeSeconds / 3600.0f);
            return kilometersPerHour;
        }

        public float CalculateMilesPerHour(float meters, float hour, float minutes, float seconds)
        {
            var timeSeconds = (hour * 3600) + (minutes * 60) + seconds;
            var kilometersPerHour = (meters / 1000.0f) / (timeSeconds / 3600.0f);
            var milesPerHour = kilometersPerHour / 1.609f;
            return milesPerHour;
        }

        #endregion

        #region Question5
        public void Question5()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Sahil Muniram");
        }

        #endregion

        #region Question6
        public void Question6()
        {
            try
            {
                Console.WriteLine("Input first number:");
                var num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nInput second number:");
                var num2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"\n{num1} + {num2} = {Add(num1, num2)}");
                Console.WriteLine($"{num1} - {num2} = {Subtract(num1, num2)}");
                Console.WriteLine($"{num1} x {num2} = {Multiply(num1, num2)}");
                Console.WriteLine($"{num1} / {num2} = {Divide(num1, num2)}");
                Console.WriteLine($"{num1} % {num2} = {Remainder(num1, num2)}");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input, please try again.\n");
                Question6();
            }
        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Remainder(int num1, int num2)
        {
            return num1 % num2;
        }
        #endregion
    }
}
