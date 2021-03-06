﻿using System;
using System.Runtime.InteropServices;

namespace TOAPI.Types
{
    [StructLayoutAttribute(LayoutKind.Sequential)]
    public struct TRACKMOUSEEVENT
    {
        /// DWORD->unsigned int
        public uint cbSize;

        /// DWORD->unsigned int
        public uint dwFlags;

        /// HWND->HWND__*
        public IntPtr hwndTrack;

        /// DWORD->unsigned int
        public uint dwHoverTime;
    }
}
