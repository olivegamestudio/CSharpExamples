/// <summary>A person record that cannot be changed, e.g. immutable.</summary>
/// <param name="FirstName"></param>
/// <param name="LastName"></param>
/// <param name="Age"></param>
public record Person(string FirstName, string LastName, int Age);
