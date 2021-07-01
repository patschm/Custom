using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OnderWater
{
    [StructLayout(LayoutKind.Explicit)]
    struct TestClass
    {
        [FieldOffset(0)]
        public int value1;
        [FieldOffset(4)]
        public long value2;
        [FieldOffset(4)]
        public double value3;
    }
}
