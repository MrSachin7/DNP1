// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Text.Json;
using TheJsonThing;

List<Person> allPersons = new List<Person>();
allPersons.Add(new Person() {
    Age = 19,
    FirstName = "Sachin",
    LastName = "Baral",
    Height = 175,
    Hobbies = new string[] {"Programming", "Playing Games", "Sleeping"},
    IsMarried = false,
    Sex = 'M'
});
allPersons.Add(new Person() {
    Age = 26,
    FirstName = "Emil",
    LastName = "Vassilev",
    Height = 174,
    Hobbies = new string[] {"Blockchain developing", "Playing Games", "Sleeping"},
    IsMarried = false,
    Sex = 'M'
});
allPersons.Add(new Person() {
    Age = 19,
    FirstName = "Himal",
    LastName = "Sharma",
    Height = 174.5,
    Hobbies = new string[] {"Cooking Farsi", "Watching Anime", "Sleeping"},
    IsMarried = false,
    Sex = 'M'
});

var serialize = JsonSerializer.Serialize(allPersons);
// Console.WriteLine(serialize);

var serializedInAReadableManner = JsonSerializer.Serialize(allPersons, new JsonSerializerOptions {
    WriteIndented = true
});
// Console.WriteLine(serializedInAReadableManner);

//write to a  file
PersonWriter.StoreObjects(allPersons);

List<Person> personsFromFile = PersonWriter.ReadObject();
personsFromFile.ForEach(Console.WriteLine);