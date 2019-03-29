namespace Chapter11
{
    public static class Q1
    {
        /// <summary>
        /// A has a large enough buffer to fit A and B in it.
        /// </summary>
        /// <param name="a">Sorted</param>
        /// <param name="b">Sorted</param>
        /// <param name="lastA"></param>
        /// <param name="lastB"></param>
        public static void Merge(int[] a, int[] b, int lastA, int lastB)
        {
            if (a == null || b == null || lastB > lastA || b.Length > a.Length)
                return;

            int iA = lastA - 1;
            int iB = lastB - 1;
            int iMerge = a.Length - 1;

            while (iB >= 0)
            {
                if (iA > 0 && a[iA] > b[iB])
                {
                    a[iMerge] = a[iA];
                    iA--;
                }
                else
                {
                    a[iMerge] = b[iB];
                    iB--;
                }

                iMerge--;
            }
        }
    }
}