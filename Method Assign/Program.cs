using System;  // Gives access to basic system functions like Console

namespace SimpleMathApp  // Namespace to group related classes together
{
    // Create a class that will contain our math method
    class Calculator
    {
        // This method takes two integers, adds 5 to the first one,
        // and prints the second number to the screen
        public void DoMath(int firstNumber, int secondNumber)
        {
            // Add 5 to the first number
            int result = firstNumber + 5;

            // Display the result of the math operation
            Console.WriteLine($"The first number plus 5 equals: {result}");

            // Display the second number as is
            Console.WriteLine($"The second number you entered is: {secondNumber}");
        }
    }

    // The Program class contains the Main() method — the starting point of the app
    class Program
    {
        static void Main(string[] args)
        {
            // Create (instantiate) an object of the Calculator class
            Calculator calc = new Calculator();

            // Call the method normally with two integers
            calc.DoMath(3, 10);

            // Call the same method again, but specify parameter names
            calc.DoMath(firstNumber: 7, secondNumber: 20);

            // Pause the program so the console window doesn't close right away
            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }
    }
}
