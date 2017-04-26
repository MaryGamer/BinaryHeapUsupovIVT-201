using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    abstract class BinaryHeap<T>
        where T : IComparable
    {
        protected List<T> list;

        public BinaryHeap()
        {
            list = new List<T>();
        }

        public int heapSize
        {
            get
            {
                return this.list.Count();
            }
        }

        public abstract void Heapify(int pos);
        protected abstract void SwapPosition(int pos);

        public void Insert(T value)
        {
            list.Add(value);
            int i = heapSize - 1;
            SwapPosition(i);
        }


        public T Extract()
        {
            if (heapSize > 0)
            {
                T result = list[0];
                list.RemoveAt(0);
                for (int i = heapSize / 2; i >= 0; i--)
                {
                    Heapify(i);
                }
                return result;
            }
            else throw new ArgumentException("Невозможно извлечь корневое значение из пустого списка");
        }
    }
}