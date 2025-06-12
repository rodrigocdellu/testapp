// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, Test App!");
Console.WriteLine();

// Exercise 1.
Console.WriteLine("Exercise 1: Read data from the JSON string.");

string jsonString = @"{
 ""name"": ""Alice"",
 ""age"": 30,
 ""birthdate"": ""1992-05-15T14:30:00Z""
}";

Console.WriteLine(String.Concat("The JSON string: ", jsonString));

var person = Person.FromJSONString(jsonString);

Console.WriteLine("The JSON object:");
Console.WriteLine(String.Concat(" The name is ", person?.name));
Console.WriteLine(String.Concat(" The age is ", person?.age));
Console.WriteLine(String.Concat(" The birthdate is ", person?.birthdate));
Console.WriteLine();

// Exercise 2.
Console.WriteLine("Exercise 2: Can you write a program that reverses the characters in a string without affecting special characters?");

// Ie "A1, b2, c3$" => "3c, 2b, 1A$"
string content1 = "A1, b2, c3$";

Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "String 1: {0} - Expected Result 1: 3c, 2b, 1A$", content1));

var result1 = StringReverser.Reverse(content1);

Console.WriteLine(result1);
Console.WriteLine();

// "###%%%1234*" => "###%%%4321*"
string content2 = "###%%%1234*";

Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "String 2: {0} - Expected Result 2: ###%%%4321*", content2));

var result2 = StringReverser.Reverse(content2);

Console.WriteLine(result2);
Console.WriteLine();
