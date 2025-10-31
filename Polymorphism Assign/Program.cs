using System;  // Provides access to basic system functionality (like Console)

namespace InterfaceExampleApp  // Namespace to organize related code
{
    // Step 1: Create an interface named IQuittable
    // An interface defines a "contract" — any class that implements it must define the methods it declares.
    interface IQuittable
    {
        // Declare a void method named Quit(). Any class that implements this interface must include this method.
        void Quit();
    }

    // Step 2: Create an Employee class that implements the IQuittable interface
    class Employee : IQuittable
    {
        // Properties for basic employee information
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Step 3: Implement the Quit() method required by the IQuittable interface
        public void Quit()
        {
            // Here we can define any behavior we want when an employee "quits"
            // For example, display a message to the console
            Console.WriteLine($"{FirstName} {LastName} (Employee ID: {Id}) has quit the job. Goodbye!");
        }
    }

    // Step 4: Main program class that runs when the console app starts
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Employee class and assign values to its properties
            Employee employee = new Employee();
            employee.Id = 101;
            employee.FirstName = "Samer";
            employee.LastName = "AlMaqadas";

            // Step 5: Use polymorphism — create an object of type IQuittable
            // Even though the underlying object is an Employee, we can store it in a variable of type IQuittable
            IQuittable quittableEmployee = employee;

            // Step 6: Call the Quit() method using the interface type
            // This works because Employee implements the IQuittable interface
            quittableEmployee.Quit();

            // Keep the console window open so we can see the output
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
