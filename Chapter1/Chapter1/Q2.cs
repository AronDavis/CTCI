using System.Text;

namespace Chapter1
{
    public static class Q2
    {
        public static string Reverse(string str)
        {
            if (str == null)
                return null;

            StringBuilder sb = new StringBuilder();
            for(int i = str.Length-1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }
    }
}
