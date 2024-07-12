using CSharpExamples.Records;

await Records.Compare.TwoIdenticalPeople();
await Records.Compare.TwoDifferentPeople();
await Records.Compare.TwoDifferentPeopleOnlyByAge();

await Records.Mutables.ChangingPropertyValue();

await Records.With.CloneWithChanges();
