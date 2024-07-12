namespace CSharpExamples.Records;

public static partial class Records
{
    public static class Compare
    {
        public static Task TwoIdenticalPeople()
        {
            Person person1 = new("Bob", "Banana", 32);
            Person person2 = new("Bob", "Banana", 32);

            if (person1 == person2)
            {
                Console.WriteLine("Correct, person1 and person2 are the same person.");
            }

            if (person1.Equals(person2))
            {
                Console.WriteLine("Correct, person1 and person2 are the same person.");
            }

            return Task.CompletedTask;
        }

        public static Task TwoDifferentPeople()
        {
            Person bob = new("Bob", "Banana", 32);
            Person brian = new("Brian", "Apple", 34);

            if (bob != brian)
            {
                Console.WriteLine("Correct, Bob and Brian are not the same person.");
            }

            if (!bob.Equals(brian))
            {
                Console.WriteLine("Correct, Bob and Brian are not the same person.");
            }

            return Task.CompletedTask;
        }

        public static Task TwoDifferentPeopleOnlyByAge()
        {
            Person bob = new("Bob", "Banana", 32);
            Person brian = new("Bob", "Banana", 34);

            if (bob != brian)
            {
                Console.WriteLine("Correct, Bob and Brian are not the same person as the age is different.");
            }

            if (!bob.Equals(brian))
            {
                Console.WriteLine("Correct, Bob and Brian are not the same person as the age is different.");
            }

            return Task.CompletedTask;
        }
    }
}
