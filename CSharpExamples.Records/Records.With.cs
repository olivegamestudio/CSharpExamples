namespace CSharpExamples.Records;

public static partial class Records
{
    public static class With
    {
        /// <summary>
        /// For a person to ebe
        /// </summary>
        /// <returns></returns>
        public static Task CloneWithChanges()
        {
            MutablePerson person = new("Bob", "Banana", 32);

            MutablePerson updatedPerson = person with { Age = 34 };

            if (person.Age == 32 && updatedPerson.Age == 34)
            {
                Console.WriteLine("The person has changed his age.");
            }

            return Task.CompletedTask;
        }
    }
}
