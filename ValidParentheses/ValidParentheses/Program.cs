using System.Text;

namespace ValidParentheses
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool result = IsValid("([{}])");
            Console.WriteLine(result);
        }

        public static bool IsValid(string s)
        {
            int n = -1;
            while (s.Length != n)
            {
                n = s.Length;
                s = s.Replace("()", "");
                s = s.Replace("{}", "");
                s = s.Replace("[]", "");
            }
            if (s.Length == 0)
            {
                return true;
            }
            return false;
        }
    }
}