
namespace Chapter1
{
    public static class Q8
    {
        public static bool IsRotation(string s1, string s2)
        {
            if (s1 == s2)
                return true;

            if (s1 == null || s2 == null || s1.Length != s2.Length)
                return false;           

            return _isSubstring(s1 + s1, s2);
        }

        private static bool _isSubstring(string s1, string s2)
        {
            return s1.Contains(s2);
        }
    }
}
