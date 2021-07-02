using System;
using System.Runtime.InteropServices;

namespace PlatformInvocationService
{
    public class Class1
    {
          [DllImport("iets.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "doeIets")]
          static extern  void DoeIets([MarshalAs(UnmanagedType.I4)]int x, [MarshalAs(UnmanagedType.BStr)] string y);
    }
}
