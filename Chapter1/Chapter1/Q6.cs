using System.Linq;
using System.Text;

namespace Chapter1
{
    public static class Q6
    {
        /// <summary>
        /// Assumes the matrix is square
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n">Length of the sides.</param>
        public static void RotateMatrix90(int[][] arr, int n)
        {
            if (arr == null || arr.Any(a => a == null) || arr.Length != n || arr.Any(a => a.Length != n))
                return;

            for(int layer = 0; layer < n/2; layer++)
            {
                int first = layer;
                int last = (n - 1) - layer;
                for(int i = first; i < last; i++)
                {
                    int offset = i - first;
                    int top = arr[first][i];

                    // left to top
                    arr[first][i] = arr[last - offset][first];

                    //bottom to left
                    arr[last - offset][first] = arr[last][last - offset];

                    //right to bottom
                    arr[last][last - offset] = arr[i][last];

                    //top to right
                    arr[i][last] = top;
                }
            }
        }
    }
}
