using System.Linq;
using System.Text;

namespace Chapter1
{
    public static class Q7
    {
        /// <summary>
        /// Assumes the matrix is rectangular.
        /// </summary>
        /// <param name="arr"></param>
        public static void SetZeros(int[][] arr)
        {
            //handle bad input
            if (arr == null || arr.Length == 0 || arr.Any(a => a == null || a.Length != arr[0].Length))
                return;

            bool[] shouldNullRow = new bool[arr.Length];
            bool[] shouldNullColumn = new bool[arr[0].Length];

            for (int r = 0; r < arr.Length; r++)
            {
                for (int c = 0; c < arr[r].Length; c++)
                {
                    if(arr[r][c] == 0)
                    {
                        shouldNullRow[r] = true;
                        shouldNullColumn[c] = true;
                    }
                }
            }
            for(int i = 0; i < shouldNullRow.Length; i++)
            {
                if (shouldNullRow[i])
                {
                    for (int j = 0; j < arr[i].Length; j++)
                        arr[i][j] = 0;
                }
            }

            for (int i = 0; i < shouldNullColumn.Length; i++)
            {
                if (shouldNullColumn[i])
                {
                    for (int j = 0; j < arr.Length; j++)
                        arr[j][i] = 0;
                }
            }
        }
    }
}
