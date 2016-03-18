using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaliiR
{
    interface ISorter<T> : IPrintable
    {
        void GeneralSort();
        void Swap(ref T x, ref T y);

    }
}
