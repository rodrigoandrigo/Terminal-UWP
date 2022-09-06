using System.Runtime.InteropServices;

namespace ProcessUWP.ConPTY.Interop.Definitions
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct Coordinates
    {
        public short X;
        public short Y;
    }
}
