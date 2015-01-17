using System;
/*
 A marketing company wants to keep record of its employees. Each record would have the following characteristics:

    First name
    Last name
    Age (0...100)
    Gender (m or f)
    Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
 */
class EmployeeData
{
    static void Main()
    {
        string firstName = "Stefan";
        string lastName = "Stefanov";
        byte age = 43;
        char gender = 'M';
        long personalIDNumber = 8306132677;
        int uniqueEmployeeNumber = 27569979;

        Console.WriteLine(@"Employee data:
First name: {0}
Last name: {1}
Age: {2}
Gender: {3}
Personal ID number: {4}
Unique emplyee number: {5}", firstName, lastName, age, gender, personalIDNumber, uniqueEmployeeNumber);
    }
}