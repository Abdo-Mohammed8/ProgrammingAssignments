using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_ADV02
{
    public class FixedSizeList<T>
    {
        private T[] items;
        private int count = 0;
        private int capacity;

        public FixedSizeList(int capacity)
        {
            this.capacity = capacity;
            items = new T[capacity];
        }

        public void Add(T item)
        {
            if (count >= capacity)
            {
                throw new InvalidOperationException("List is full");
            }
            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            return items[index];
        }
    }

}
