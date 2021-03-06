﻿using System;
using System.Runtime.InteropServices;

namespace TOAPI.WinMM
{
    /// <summary>
    /// This structure is used by the Waveform Audio routines.  It is a class instead of a structure
    /// because it is always used by reference.  
    /// 
    /// As such though, the copy assignments need to be implemented.
    /// </summary>
    [StructLayoutAttribute(LayoutKind.Sequential)]
    public struct WAVEHDR : IDisposable
    {
        public static WAVEHDR Empty = new WAVEHDR();

        public IntPtr lpData;     /// Pointer to data buffer
        public uint dwBufferLength;         /// Length of data buffer
        public uint dwBytesRecorded;        /// When used for input, number of bytes recorded
        public IntPtr dwUser;               /// User specified data
        public uint dwFlags;                /// DWORD->unsigned int
        public uint dwLoops;                /// Number of times to play the loop.
        public IntPtr lpNext;     /// RESERVED - wavehdr_tag*
        public IntPtr reserved;             /// Must be Zero

        public WAVEHDR(int bufferLength)
        {

            lpData = Marshal.AllocCoTaskMem(bufferLength);
            dwBufferLength = (uint)bufferLength;
            dwBytesRecorded = 0;        /// When used for input, number of bytes recorded
            dwUser = IntPtr.Zero;               /// User specified data
            dwFlags = 0;                /// DWORD->unsigned int
            dwLoops = 0;                /// Number of times to play the loop.
            lpNext = IntPtr.Zero;     /// RESERVED - wavehdr_tag*
            reserved = IntPtr.Zero;             /// Must be Zero
        }

        public void Dispose()
        {
            if (IntPtr.Zero != lpData)
                Marshal.FreeCoTaskMem(lpData);
        }
    }
}
