﻿using System;
using System.Runtime.InteropServices;

namespace TOAPI.WinMM
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WAVEINCAPSW
    {
        public ushort wMid;             /// WORD->unsigned short
        public ushort wPid;             /// WORD->unsigned short
        public uint vDriverVersion;     /// MMVERSION->UINT->unsigned int

        /// WCHAR[32]
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;
        public uint dwFormats;          /// DWORD->unsigned int
        public ushort wChannels;        /// WORD->unsigned short
        public ushort wReserved1;       /// WORD->unsigned short
    }

    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WAVEINCAPSA
    {
        public ushort wMid;         /// WORD->unsigned short
        public ushort wPid;         /// WORD->unsigned short
        public uint vDriverVersion; /// MMVERSION->UINT->unsigned int
        [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;      /// CHAR[32]
        public uint dwFormats;      /// DWORD->unsigned int
        public ushort wChannels;    /// WORD->unsigned short
        public ushort wReserved1;   /// WORD->unsigned short
    }
}
