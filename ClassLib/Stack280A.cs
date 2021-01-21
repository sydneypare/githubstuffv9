using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Stack280A<T> : IStack<T>
    {

        T[] data = new T[10];
        int top = 0;
        int bottom = 0;

        public int Count()
        {
            // int tmp = 0;
            //int tmp2;
            //  foreach (T item in data)
            //  {
            //      tmp++;

            //   }
            //  tmp2 = tmp;

            int tmp2 = data.Length;
            // foreach(T item in data)




            return tmp2;
        }

        public bool Empty()
        {
            //  bool empty;

            //  if (data.Count != 0)
            //  {
            //     empty = true;
            // }
            // else
            // {
            //       empty = false;
            //  }

            bool empty;

            if(data.Length == 0)
            {
                empty = true;
            }
            else
            {
                empty = false;
            }
            return empty;
        }

        public T Peek()
        {
            return data[top];
        }

        public T Pop()
        {
            T tmp = data[top];

            top++;
            return tmp;
        }

        public void Push(T o)
        {
            if (data.Length - 1 == bottom)
            {
                T[] tmp = new T[data.Length * 2];
                data.CopyTo(tmp, 0);
                //cpuld use a loop
                data = tmp;
            }

            data[bottom] = o;
            bottom++;
        }
    }
}
