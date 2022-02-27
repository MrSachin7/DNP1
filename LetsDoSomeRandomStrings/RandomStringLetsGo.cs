namespace LetsDoSomeRandomStrings;

public class RandomStringLetsGo {
    public static Random Random = new Random();

    public static string GenerateRandomString(int length) {
        const string chars = "abchijkwxyz0123456789?";
        return new string(Enumerable.Repeat(chars, length).Select(s => s[Random.Next(s.Length)]).ToArray());
    }

    public static void PrintSumsBetweenQuestionMarks(string s) {
        int count = 0;
        foreach (char c in s) {
            if (c == '?') {
                count++;
            }
        }

        Console.WriteLine($"There are {count} ?s in the provided string");
        string temp = $"Provided string : {s} \n";
        int lastIndex = 0;
        for (int i = 0; i < count; i++) {
            int sum = 0;
            int indexOfQuestionMark = s.IndexOf('?', lastIndex+1);
            for (int j = lastIndex; j < indexOfQuestionMark; j++) {
                if (Char.IsDigit(s[j])) {
                    sum += Int32.Parse(s[j].ToString());
                }
            }
            temp += $"\t {sum}";

            lastIndex = indexOfQuestionMark;
        }

        Console.WriteLine(temp);
    }
}