namespace CheckForPalindrome;

public class Palindrome {
    public static bool IsPalindrome(string word) {

        string trimmedWord = String.Concat(word.Where(c => !Char.IsWhiteSpace(c)));
        Console.WriteLine(trimmedWord);

        // take the 1st half of the string ..
        string first = trimmedWord.Substring(0, trimmedWord.Length / 2);
       // Console.WriteLine($"First : {first}");

        // convert it to array of chars..
        char[] array = trimmedWord.ToCharArray();

        // reverse it using the in-built function..
        Array.Reverse(array);

        // make a new string from the reversed array..
        string temp = new string(array);

        // Now take the half of that reversed string
        string second = temp.Substring(0, temp.Length / 2);
       // Console.WriteLine($"Second : {second}");

        
        // return if they are equal..
        return first.Equals(second);
    }
}