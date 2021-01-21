using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    interface IStack<T>
    {

        void Push(T o);
        T Pop();
        T Peek();
        int Count();
        bool Empty();


    }
}
