using System;

namespace ShippingQuoteCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializes the shipping service interface with a customer greeting
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Acquires and processes the customer's input for package weight
            Console.WriteLine("Please enter the package weight:");
            float weight = Convert.ToSingle(Console.ReadLine());

            // Screens the package against the company's maximum weight policy
            if (weight > 50)
            {
                // Issues a service denial notification for weight policy violations
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Terminates the shipping process for non-compliant weight
            }

            // Solicits and registers the package's width dimension
            Console.WriteLine("Please enter the package width:");
            float width = Convert.ToSingle(Console.ReadLine());

            // Solicits and registers the package's height dimension
            Console.WriteLine("Please enter the package height:");
            float height = Convert.ToSingle(Console.ReadLine());

            // Solicits and registers the package's length dimension
            Console.WriteLine("Please enter the package length:");
            float length = Convert.ToSingle(Console.ReadLine());

            // Conducts a dimensional compliance check against shipping standards
            if (width + height + length > 50)
            {
                // Delivers a dimensional non-compliance message to the customer
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Concludes the shipping request due to size restrictions
            }

            // Calculates the shipping fee using the established pricing model
            float quote = (height * width * length * weight) / 100;

            // Communicates the final shipping cost to the customer with proper formatting
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Maintains the application state until user acknowledgment is received
            Console.ReadKey();
        }
    }
}