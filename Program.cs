using Employee;
using Bogus;

// Set some random full name
var faker = new Faker();
string randomName = faker.Name.FullName();
Console.WriteLine(randomName);

// We have a EmployeeInfo which we want to fill, lets fill hundred!
for(int i = 0; i < 100; i++)
{
    var bogusEmployee = EmployeeExtensions.GetBogusEmployee();
    Console.WriteLine("####################################");
    Console.WriteLine($"First Name: {bogusEmployee.FirstName}");
    Console.WriteLine($"Last Name: {bogusEmployee.LastName}");
    Console.WriteLine($"Gender: {bogusEmployee.Gender}");
    Console.WriteLine($"Age: {bogusEmployee.Age}");
}