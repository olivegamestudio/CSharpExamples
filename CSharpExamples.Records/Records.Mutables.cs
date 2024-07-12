namespace CSharpExamples.Records;

public static partial class Records
{
    public static class Mutables
    {
        /// <summary>
        /// For a person to ebe
        /// </summary>
        /// <returns></returns>
        public static Task ChangingPropertyValue()
        {
            MutablePerson person = new("Bob", "Banana", 32);

            person.LastName = "Apple";
            if (person.LastName == "Apple")
            {
                Console.WriteLine("The person has changed his last name.");
            }

            return Task.CompletedTask;
        }
    }
}
