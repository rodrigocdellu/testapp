
using System.Text.Json;

public sealed class Person
{
    public string name { get; set; }

    public uint age { get; set; }

    public DateTime birthdate { get; set; }

    public Person()
    {
        this.name = String.Empty;
        this.age = 0u;
        this.birthdate = DateTime.MinValue;
    }

    public static Person? FromJSONString(string jsonString)
    {
        try
        {
            var person = JsonSerializer.Deserialize<Person>(jsonString);

            return person;
        }
        catch
        {
            throw new Exception("Was not possible to deserialize.");
        }
    }
}
