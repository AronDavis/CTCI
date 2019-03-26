using System.Text;

namespace Chapter1
{
    public static class Q5
    {
        /// <summary>
        /// Assumes [a-zA-Z]
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Compress(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            StringBuilder sb = new StringBuilder();

            int currentGroupCount = 1;
            char currentGroup = str[0];
            for(int i = 1; i < str.Length; i++)
            {
                char c = str[i];

                if (c == currentGroup)
                {
                    currentGroupCount++;
                }
                else
                {
                    sb.Append(currentGroup);
                    sb.Append(currentGroupCount);

                    currentGroup = c;
                    currentGroupCount = 1;
                }
            }

            sb.Append(currentGroup);
            sb.Append(currentGroupCount);

            string final = sb.ToString();

            if (final.Length < str.Length)
                return final;

            return str;
        }
    }
}
