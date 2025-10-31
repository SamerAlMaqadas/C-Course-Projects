using System;  // Gives access to basic system functionality, including Console

namespace EmployeeComparisonApp  // A namespace to organize our code
{
    // The Employee class represents an employee with three basic properties
    class Employee
    {
        // Property to hold a unique employee ID
        public int Id { get; set; }

        // Property to hold the employee's first name
        public string FirstName { get; set; }

        // Property to hold the employee's last name
        public string LastName { get; set; }

        // Overload the "==" operator to compare two Employee objects by their Id property
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both objects are null, they are considered equal
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one of them is null, they are not equal
            if (((object)emp1 == null) || ((object)emp2 == null))
                return false;

            // Compare their Id values
            return emp1.Id == emp2.Id;
        }

        // Overload the "!=" operator (must be paired with "==")
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the opposite of the "==" operator
            return !(emp1 == emp2);
        }

        // Override Equals() to be consistent with the == operator
        public override bool Equals(object obj)
        {
            // Check if the object is an Employee
            Employee other = obj as Employee;
            if (other == null)
                return false;

            // Compare Ids
            return this.Id == other.Id;
        }

        // Override GetHashCode() whenever Equals() is overridden
        public override int GetHashCode()
        {
            // Use Id as the hash code basis
            return this.Id.GetHashCode();
        }
    }

    // The Program class contains the Main() method, which is the program entry point
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object and assign values
            Employee employee1 = new Employee();
            employee1.Id = 1;
            employee1.FirstName = "Samer";
            employee1.LastName = "AlMaqadas";

            // Create the second Employee object and assign values
            Employee employee2 = new Employee();
            employee2.Id = 2;  // Try changing this to 1 to see the equality check in action
            employee2.FirstName = "Test";
            employee2.LastName = "User";

            // Compare the two Employee objects using the overloaded "==" operator
            bool areEqual = employee1 == employee2;

            // Display the result of the comparison
            Console.WriteLine("Are the two employees equal (by Id)? " + areEqual);

            // Use the overloaded "!=" operator to show the opposite comparison
            bool areNotEqual = employee1 != employee2;

            // Display the result of the "!=" comparison
            Console.WriteLine("Are the two employees NOT equal (by Id)? " + areNotEqual);

            // Keep the console open so you can see the results
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
