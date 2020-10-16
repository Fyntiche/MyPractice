using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace Buffer
{
    internal interface IBuffer<T>
    {
        bool IsEmpry { get; }

        void Write(T value);

        T Read();
    }
}