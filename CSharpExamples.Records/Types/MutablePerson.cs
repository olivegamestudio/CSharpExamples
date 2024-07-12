/// <summary>A person record that can be changed e.g. mutable.</summary>
/// <param name="FirstName"></param>
/// <param name="LastName"></param>
/// <param name="Age"></param>
public record struct MutablePerson(string FirstName, string LastName, int Age);
