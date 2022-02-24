namespace SurroundString;

public class AnotherSubstring
{
    public static string NTwice(string word, int n)
    {
        var substring1 = word.Substring(0, n);
        var substring2 = word.Substring(word.Length - n, n);
        return $"{substring1}{substring2}";
    }
}