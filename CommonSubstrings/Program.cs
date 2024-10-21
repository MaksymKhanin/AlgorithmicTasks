using ConsoleApp1;

namespace InterviewQuestions
{
    class Program
    {
        public static void Main(string[] args)
        {
            var listA = new List<string> { "abcdefghijklm", new string('z', 10000), "pqrst", new string('f', 9999) + "e" };
            var listB = new List<string> { "nopqrstuvwxyz", new string('a', 10000), "abcdef", new string('e', 9999) + "f" };

            Result.commonSubstring(listA, listB);
        }
    }
}