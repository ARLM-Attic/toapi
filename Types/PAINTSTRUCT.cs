using System;
using System.Runtime.InteropServices;

namespace TOAPI.Types
{
	[StructLayout(LayoutKind.Sequential)]
	public struct PAINTSTRUCT
	{
		public IntPtr hdc;
        [MarshalAsAttribute(UnmanagedType.Bool)]
        public bool fErase;
		public RECT rcPaint;
        [MarshalAsAttribute(UnmanagedType.Bool)]
        public bool fRestore;
        [MarshalAsAttribute(UnmanagedType.Bool)]
        public bool fIncUpdate;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
		public byte[] rgbReserved;

        public void Init()
        {
            rgbReserved = new byte[32];
        }
	}
}