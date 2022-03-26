using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.leet
{
    public class MaximumPoints_1937
    {
        static void Main2(string[] args)
        {
            int[][] jaggedArray2 = new int[][]
                {
                /*new int[] { 1,2,3},
                new int[] { 1,5,1},*/
                new int[] { 1, 3,1,1 }
                };
            
            long res  = new MaximumPoints_1937().MaxPoints(jaggedArray2);
        }
        public long MaxPoints(int[][] points)
        {
            long result = long.MinValue;
            if (points.Length == 0)
            {
                return 0;
            }
            if (points.Length == 1)
            {
                for (int i = 0; i < points[0].Length; i++)
                {
                    result = Math.Max(result, points[0][i]);
                }
                return result;
            }
            long[][] dp = new long[points.Length][];
            for (int i = 0; i < points.Length; i++)
            {
                dp[i] = new long[points[0].Length];
                for (int j = 0; j < points[0].Length; j++)
                {
                    dp[i][j] = points[i][j];
                }
            }
            for (int i = 1; i < points.Length; i++)
            {
                for (int j = 0; j < points[0].Length; j++)
                {
                    for (int k = 0; k < points[0].Length; k++)
                    {
                        dp[i][j] = Math.Max(dp[i][j], points[i][j] + dp[i - 1][k] - Math.Abs(j - k));
                        if (result < dp[i][j])
                        {
                            result = dp[i][j];
                        }
                    }

                }
            }
            return result;
        }

        public long MaxPoints2(int[][] points)
        {
            long result = long.MinValue;
            if(points.Length == 0)
            {
                return 0;
            }
            if(points.Length == 1)
            {
                for (int i = 0; i < points[0].Length; i++)
                {
                    result = Math.Max(result, points[0][i]);
                }
                 return result;
            }
            long[][] dp = new long[points.Length][];
            for(int i = 0; i < points.Length; i++)
            {
                dp[i] = new long[points[0].Length];
                for (int j = 0; j < points[0].Length; j++)
                {
                    dp[i][j] = points[i][j];
                }
            }
            for (int i = 1; i < points.Length; i++)
            {
                for (int j = 0; j < points[0].Length; j++)
                {
                    for( int k = 0; k < points[0].Length; k++)
                    {
                        dp[i][j] = Math.Max(dp[i][j], points[i][j] + dp[i - 1][k] - Math.Abs(j-k));
                        if(result < dp[i][j])
                        {
                            result = dp[i][j];
                        }
                    }
                    
                }
            }
            return result;
        }
        
    }
}
