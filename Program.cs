namespace PolindromeNumber
{
    /// <summary>
    /// Given an integer x, return true if x is a palindrome, and false otherwise.
    /// </summary>
    public class Solution
    {
        public static bool IsPalindrome(int x)
        {
            bool resultOfNumber = false;
            int j = 0;
            int k = 0;
            //int[] digits = x.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();
            string xText = x.ToString(); // Integer to text conversion
            char[] words = xText.ToCharArray();// Array with index for each char or digit
            char[] chars = new char[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                chars[i] = words[i];// Extra array for comparison with another array
            }
            Array.Reverse(words);// Reverse array digits
            if (chars[j] == words[k])
            {
                resultOfNumber = true;
                Console.WriteLine(resultOfNumber);
            }
            else
            {
                Console.WriteLine(resultOfNumber);
            }
            return resultOfNumber;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Solution.IsPalindrome(x);
        }
    }
}