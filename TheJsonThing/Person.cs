using System.Threading.Channels;

namespace TheJsonThing;

public class Person {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public double Height { get; set; }
    public bool IsMarried { get; set; }
    public char Sex { get; set; }
    public string[] Hobbies { get; set; }

    public override string ToString() {
        string a = $"FirstName : {FirstName}  \t LastName : {LastName}";
        return a;
    }
}