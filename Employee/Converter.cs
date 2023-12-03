using System;

class Employee
{
    private string lastName;
    private string firstName;

    // Constructor to initialize last name and first name
    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    // Method to calculate salary and tax
    public void CalculateSalaryAndTax(string position, int experience)
    {
        // Your logic to calculate salary based on position and experience
        double baseSalary = 50000; // Example base salary
        double bonus = experience * 2000; // Example bonus based on experience

        double salary = baseSalary + bonus;

        // Your logic to calculate tax based on salary
        double taxRate = 0.1; // Example tax rate
        double tax = salary * taxRate;

        // Display employee information
        Console.WriteLine($"Employee Information:");
        Console.WriteLine($"Last Name: {lastName}");
        Console.WriteLine($"First Name: {firstName}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Salary: {salary:C2}");
        Console.WriteLine($"Tax: {tax:C2}");
    }
}
