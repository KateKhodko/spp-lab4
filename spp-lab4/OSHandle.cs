using System;
using System.Runtime.InteropServices;

namespace spp_lab4
{
    public class OSHandle:IDisposable
    {
        [DllImport("Kernel32.dll")]
        private static extern bool CloseHandle(IntPtr handle);
        public IntPtr Handle { get; set; }
        
        private bool _disposed;
        
        public OSHandle()
        {
            Handle = IntPtr.Zero;
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                CloseHandle(Handle);
                Handle = IntPtr.Zero;
                _disposed = true;
            }
        }
        
        ~OSHandle()
        {
            Dispose (false);
        }
    }
}