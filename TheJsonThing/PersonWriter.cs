
using System.Text.Json;

namespace TheJsonThing; 

public class PersonWriter {
   public static void StoreObjects(List<Person> persons) {
       var serialized = JsonSerializer.Serialize(persons,new JsonSerializerOptions() {
         WriteIndented = true
       });
       using StreamWriter sw = new StreamWriter("Persons.txt");
       sw.WriteLine(serialized);
   }

   public static List<Person> ReadObject() {
       // StringBuilder sb = new StringBuilder();
       // using StreamReader sr = new StreamReader("Persons.txt");
       // string line;
       // while ((line=sr.ReadLine())!=null) {
       //     sb.AppendLine(line);
       //
       // }
       //
       var jsonFromFile = File.ReadAllText("Persons.txt");


       List<Person>? deserializedList = JsonSerializer.Deserialize<List<Person>>(jsonFromFile);
       return deserializedList;
   }
}