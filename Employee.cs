using Bogus;

namespace Employee;

public class EmployeeInfo
{
    private static readonly Faker<EmployeeInfo> Faker = new Faker<EmployeeInfo>()
        .RuleFor(e => e.FirstName, f => f.Name.FirstName())
        .RuleFor(e => e.LastName, f => f.Name.LastName())
        .RuleFor(e => e.Gender, f => f.PickRandom<Gender>())
        .RuleFor(e => e.Age, f => f.Random.Int(18, 67));

    public static EmployeeInfo Fake() => Faker.Generate();

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Gender? Gender {get; set; }
    public int? Age { get; set; }
}

public enum Gender
{
    Male,
    Female
}