// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, TestApp!");
Console.WriteLine();

#region Exercise 1

Console.WriteLine("Exercise 1: Can you write a program to read data from the JSON string?");

var jsonString = @"
 {
  ""name"": ""Alice"",
  ""age"": 30,
  ""birthdate"": ""1992-05-15T14:30:00Z""
 }";

var jsonObject = Person.FromJSONString(jsonString);

Console.WriteLine("The JSON object:");
Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "    The name is \"{0}\"", jsonObject?.name));
Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "    The age is \"{0}\"", jsonObject?.age));
Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "    The birthdate is \"{0}\"", jsonObject?.birthdate));

#endregion

Console.WriteLine();

#region Exercise 2

Console.WriteLine("Exercise 2: Can you write a program that reverses the characters in a string without affecting special characters?");

// "A1, b2, c3$" => "3c, 2b, 1A$"
var inputString1 = "A1, b2, c3$";

Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "    Input String 1: \"{0}\" - Expected Output String 1: 3c, 2b, 1A$", inputString1));
Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "    Output String 1: \"{0}\"", StringReverser.Reverse(inputString1)));

// "###%%%1234*" => "###%%%4321*"
var inputString2 = "###%%%1234*";

Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "    Input String 2: \"{0}\" - Expected Output String 2: ###%%%4321*", inputString2));
Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "    Output String 2: \"{0}\"", StringReverser.Reverse(inputString2)));

#endregion

Console.WriteLine();

#region Exercise 3

Console.WriteLine("Exercise 3: Can you write a program that indicates the last word lenght?");

var result1 = StringManipulator.Manipulate("Hello World");
Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "    Last word: \"{0}\" - Length: \"{1}\"", result1, result1.Length));

var result2 = StringManipulator.Manipulate("   fly me   to   the moon  ");
Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "    Last word: \"{0}\" - Length: \"{1}\"", result2, result2.Length));

#endregion

Console.WriteLine();
