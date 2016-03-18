using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaliiR
{
    interface IBuffer<T>:IPrintable
    {
        bool IsFull();
        bool IsEmpty();
        T PopDequeue();
        T PushEnqueue(T item);
        T Peek();
    }
}
