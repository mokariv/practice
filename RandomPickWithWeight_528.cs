using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.leet
{
    public class RandomPickWithWeight_528
    {
        static void Main2(string[] args)
        {
            RandomPickWithWeight_528 obj = new RandomPickWithWeight_528(new int[] { 1, 3, 4, 5 });
            int param_1 = obj.PickIndex();
            Console.WriteLine(param_1);
        }
        int[] arr;
        int sum = 0;

      

        public RandomPickWithWeight_528(int[] w)
        {
            arr = new int[w.Length];
            for (int i = 0; i< w.Length; i++)
            {
                sum += w[i];
                arr[i] = sum;
            }
        }

        public int PickIndex()
        {
            Random rnd = new Random();
            int rand = rnd.Next(1, sum+1);

            int res = bs(arr, rand, 0 , arr.Length);
            return res;
        }

        private int bs(int[] arr, int rand, int start, int end)
        {
            int mid = start +  (end - start) / 2;

            if(start == end)
            {
                return start;
            }

            if( start == mid)
            {
                return arr[start] >= rand ? start: end;
            }
            if(arr[mid] < rand)
            {
                return bs(arr, rand, mid + 1, end);
            } else
            {
                return bs(arr, rand, start, mid);
            }
        }
    }
}
