using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.leet
{
    public class KthLargest_215
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6]{ 3, 54, 667, 7, 78, 8 };
            KthLargest_215 obj = new KthLargest_215(arr);
            Console.WriteLine(obj.extractMax());
            Console.WriteLine(obj.extractMax());

        }


        int[] heapArr;
        int heapSize;
        public KthLargest_215(int[] arr)
        {
            heapArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                heapArr[i] = arr[i];
            }
            heapSize = arr.Length;

            int j = (heapSize - 1) / 2;
            while(j >= 0)
            {
                maxHeapify(j);
                j--;
            }

        }

       
        public int getLeft(int i)
        {
            return 2 * i+1;
        }

        public int getRight(int i)
        {
            return 2 * i +2 ;
        }

        public int getParent(int i)
        {
            return i/2;
        }
        private void maxHeapify(int i)
        {
            int left = getLeft(i);
            int right = getRight(i);

            int maximum = i;
            if( left< heapSize && heapArr[left] > heapArr[i])
            {
                maximum = left;
            }
            if (right < heapSize && heapArr[right] > heapArr[maximum])
            {
                maximum = right;
            }


            if(maximum != i)
            {
                int temp = heapArr[maximum];
                heapArr[maximum] = heapArr[i];
                heapArr[i] = temp;

                maxHeapify(maximum);
            }

        }

        private int extractMax()
        {
            int result = heapArr[0];
            heapArr[0] = heapArr[heapSize - 1];
            heapSize--;
            maxHeapify(0);
            return result;

        }
    }
}
