namespace jarai.tdd6.AutoFixture;

public class Person
{
    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public DateTime DateOfBirth { get; set; }

    public Pet[] Pets { get; set; } = Array.Empty<Pet>();
}