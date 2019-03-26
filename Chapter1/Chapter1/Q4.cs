namespace Chapter1
{
    public static class Q4
    {
        /// <summary>
        /// Replaces spaces with "%20".
        /// Assumes the array has enough space for the shift.
        /// </summary>
        /// <param name="str"></param>
        public static void ReplaceSpacesInPlace(char[] str, int initialLength)
        {
            if (str == null)
                return;

            if (initialLength > str.Length)
                return;

            int shiftI = str.Length - 1;
            for(int i = initialLength-1; i >= 0; i--, shiftI--)
            {
                char c = str[i];

                if(c == ' ')
                {
                    str[shiftI] = '0';
                    str[--shiftI] = '2';
                    str[--shiftI] = '%';
                }
                else
                {
                    str[shiftI] = c;
                }
            }
        }
    }
}
