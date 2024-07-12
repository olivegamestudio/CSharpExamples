namespace CSharpExamples.Records;

static class Records
{
    public static void TwoIdenticalPeople()
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
    }

    public static void TwoDifferentPeople()
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
    }

    public static void TwoDifferentPeopleOnlyByAge()
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
    }
}
