using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    class MaxBinaryHeap<T> : BinaryHeap<T>
        where T : IComparable
    {
        public MaxBinaryHeap()
            : base()
        {
        }


        protected override void SwapPosition(int i)
        {
            int parent = (i - 1) / 2;

            while (i > 0)
            {
                if (list[i].CompareTo(list[parent]) > 0)
                {
                    T temp = list[i];
                    list[i] = list[parent];
                    list[parent] = temp;

                    i = parent;
                    parent = (i - 1) / 2;
                }
            }
        }


        public override void Heapify(int i)
        {
            int leftChild = 2 * i + 1;
            int rightChild = 2 * i + 2;
            int largestChild = i;

            if (leftChild < heapSize && (list[leftChild].CompareTo(list[largestChild]) > 0))
            {
                largestChild = leftChild;
            }
            if (rightChild < heapSize && (list[rightChild].CompareTo(list[largestChild]) > 0))
            {
                largestChild = rightChild;
            }
            if (largestChild != i)
            {
                T temp = list[i];
                list[i] = list[largestChild];
                list[largestChild] = temp;
                i = largestChild;
            }
        }

    }
}
