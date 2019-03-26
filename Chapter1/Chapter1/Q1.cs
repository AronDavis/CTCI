using System.Linq;

namespace Chapter1
{
    public static class Q1
    {
        public static bool HasUniqueChars(string str)
        {
            if (str == null)
                return true;

            return str.GroupBy(c => c).All(g => g.Count() <= 1);
        }
    }
}
