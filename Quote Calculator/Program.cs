using System;

class ShippingCalculator
{
    static void Main()
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        try
        {
            // Ask for the weight of the parcel
            Console.Write("Enter the weight of your package: ");
            double packageWeight = Convert.ToDouble(Console.ReadLine());

            // Reject if weight exceeds limit
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Ask for the package dimensions
            Console.Write("Enter the width of the package: ");
            double packageWidth = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the package: ");
            double packageHeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of the package: ");
            double packageLength = Convert.ToDouble(Console.ReadLine());

            // Calculate combined size
            double totalSize = packageWidth + packageHeight + packageLength;

            // Reject if size exceeds limit
            if (totalSize > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Calculate estimated cost
            double dimensionProduct = packageWidth * packageHeight * packageLength;
            double shippingCost = (dimensionProduct * packageWeight) / 100.0;

            // Output the final quote
            Console.WriteLine($"Your estimated shipping total is: ${shippingCost:F2}");
            Console.WriteLine("Thank you for using Package Express!");
        }
        catch (Exception)
        {
            // General catch block for any conversion errors
            Console.WriteLine("Input error: Please ensure you are entering valid numbers.");
        }
    }
}
