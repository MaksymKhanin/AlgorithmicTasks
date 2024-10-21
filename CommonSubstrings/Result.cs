namespace ConsoleApp1;
class Result
{
    private static string PositiveOutput = "YES";
    private static string NegativeOutput = "NO";

    public static void commonSubstring(List<string> a, List<string> b)
    {
        for (int i = 0; i < a.Count; i++)
        {
            Console.WriteLine(HaveCommonSubstring(a[i], b[i]) ? PositiveOutput : NegativeOutput);
        }
    }

    // Check if two strings have a common substring with tine complexity O(n + m). Space complexity: O(n)
    public static bool HaveCommonSubstring(string s1, string s2)
    {
        // Store unique characters from the first string. Time complexity O(n), where n = s1

        HashSet<char> charSet = new HashSet<char>(s1);

        // Check if any character from the second string exists in the HashSet. Time complexity O(m), where m = s2

        foreach (char c in s2)
        {
            if (charSet.Contains(c)) return true;
        }

        return false;
    }
}
