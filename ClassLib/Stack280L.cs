using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Stack280L<T> : IStack<T>
    {

        List<T> data = new List<T>();
        //return num od objects in the stack
        
        //this one is fucked
        public int Count()
        {

            //throw new NotImplementedException();


            //foreach (T Item in data)
            //{
            //  tmp;
            //}
            // T tmp =data.Capacity();
            int tmp = 0;
           //foreach(data.Count());
           // foreach(T item in data)
           // {
           //      tmp;
           // }
            
           
            return tmp;
        }

        //return a bool
        public bool Empty()
        {
            bool empty;

            if(data.Count ==0)
            {
                empty = true;
            }
            else
            {
                empty = false;
            }

             
            return empty;
        }

        //return last item pushed into stack
        public T Peek()
        {
            return data[0];
        }

        //this one is fucked
        public T Pop()
        {
            //T data2;



            //  T tmp;

            // tmp = data[0];


            // return tmp;

            T tmp;
            data.RemoveAt(0);
            tmp = data[0];

            return tmp;



        }

        public void Push(T o)
        {
            data.Add(o);
        }
    }
}
