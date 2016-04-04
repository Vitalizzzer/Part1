using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaliiR
{
    interface IMyQueue<T>
    {
        T PopDequeue();
        T Peek();
    }
}
