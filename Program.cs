namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.IsPalindrome(10));
            Console.ReadKey();
        }
    }

    public static class Solution
    {
        public  static bool IsPalindrome(int x)
        {
            var ls = x.ToString().Select(item => item)?.ToList() ?? new List<char>();

            var reverseString = new List<char>();

            for (int i = 0; i < ls.Count; i++)
            {
                reverseString.Add(ls[(ls.Count - 1) - i]);
            }

            for(int i = 0; i < ls.Count; i++)
            {
                if (ls[i] != reverseString[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}