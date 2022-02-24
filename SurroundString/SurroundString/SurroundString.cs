namespace SurroundString;

public class SurroundString
{
    public static string MakeOurWord(string surroundWith, string surroundTo)
    {
        string surrounder1 = surroundWith.Substring(0, 2);
        string surrounder2 = surroundWith.Substring(2, 2);
        return $"{surrounder1}{surroundTo}{surrounder2}";
    }
}