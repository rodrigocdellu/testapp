// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, Test App!");
Console.WriteLine();

// Exercise 1.
Console.WriteLine("Exercise 1: Read data from the JSON string.");

string jsonString = @"
 {
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

// "A1, b2, c3$" => "3c, 2b, 1A$"
string inputString1 = "A1, b2, c3$";

Console.WriteLine(String.Format(CultureInfo.InvariantCulture, " Input String 1: {0} - Expected Output String 1: 3c, 2b, 1A$", inputString1));

var outputString1 = StringReverser.Reverse(inputString1);

Console.WriteLine(String.Format(CultureInfo.InvariantCulture, " Output String 1: {0}", outputString1));
Console.WriteLine();

// "###%%%1234*" => "###%%%4321*"
string inputString2 = "###%%%1234*";

Console.WriteLine(String.Format(CultureInfo.InvariantCulture, " Input String 2: {0} - Expected Output String 2: ###%%%4321*", inputString2));

var outputString2 = StringReverser.Reverse(inputString2);

Console.WriteLine(String.Format(CultureInfo.InvariantCulture, " Output String 2: {0}", outputString2));
Console.WriteLine();
