using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace spp_lab4
{
    class Program
    {
        [DllImport("Kernel32.dll")]
        static extern IntPtr GetStdHandle(int nStdHandle);
        
        const int STD_OUTPUT_HANDLE = -11;
        
        static void Main(string[] args)
        {
            OSHandle osHandle = new OSHandle();
            
            osHandle.Handle = GetStdHandle(STD_OUTPUT_HANDLE);
            osHandle.Dispose();
        }
    }
}