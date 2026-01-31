namespace LeetCode.Solutions.Top150.Topic010_Matrix
{
    internal class Spiral_Matrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            int left = 0;
            int right = matrix[0].Length - 1;
            int top = 0;
            int bottom = matrix.Length - 1;
            List<int> spiral = new List<int>();

            while (left <= right && top <= bottom)
            {
                for (int i = left; i <= right; i++)
                {
                    spiral.Add(matrix[top][i]);
                }
                top++;

                for (int j = top; j <= bottom; j++)
                {
                    spiral.Add(matrix[j][right]);
                }
                right--;

                if (bottom >= top)
                {
                    for (int k = right; k >= left; k--)
                    {
                        spiral.Add(matrix[bottom][k]);
                    }
                    bottom--;
                }
                if (right >= left)
                {
                    for (int a = bottom; a >= top; a--)
                    {
                        spiral.Add(matrix[a][left]);
                    }
                    left++;
                }
            }
            return spiral;
        }
    }
}
