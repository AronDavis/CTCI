using System.Collections.Generic;
using System.Linq;

namespace Chapter1
{
    public static class Q3
    {
        public static bool IsPermutation(string s1, string s2)
        {
            if (s1 == null && s2 == null)
                return true;

            //if only one is null
            if (s1 == null)
                return false;

            //if only one is null
            if (s2 == null)
                return false;

            //if differing lengths
            if (s1.Length != s2.Length)
                return false;

            Dictionary<char, int> letterCount = _stringToLetterCount(s1);

            for(int i = 0; i < s2.Length; i++)
            {
                char c = s2[i];

                //if the letter isn't in s1, then we know it's not a permutation
                if (!letterCount.ContainsKey(c))
                    return false;

                int count = --letterCount[c];

                if (count == 0)
                    letterCount.Remove(c);
            }

            //they're permutations if we end up with the same counts
            return letterCount.Keys.Count == 0;
        }

        private static Dictionary<char, int> _stringToLetterCount(string str)
        {
            return str.GroupBy(c => c)
                .ToDictionary(g => g.First(), g => g.Count());
        }
    }
}
