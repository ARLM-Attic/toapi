﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace TOAPI.WinMM
{
    public partial class winmm
    {
        [DllImportAttribute("winmm.dll", EntryPoint = "midiConnect")]
        public static extern int midiConnect(IntPtr hmi, IntPtr hmo, IntPtr pReserved);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiDisconnect")]
        public static extern int midiDisconnect(IntPtr hmi, IntPtr hmo, IntPtr pReserved);




        [DllImportAttribute("winmm.dll", EntryPoint = "midiInOpen")]
        public static extern int midiInOpen(ref IntPtr phmi, int uDeviceID, int dwCallback, int dwInstance, int fdwOpen);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiInStop")]
        public static extern int midiInStop(IntPtr hmi);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiInClose")]
        public static extern int midiInClose(IntPtr hmi);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiInGetID")]
        public static extern int midiInGetID(IntPtr hmi, ref int puDeviceID);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiInReset")]
        public static extern int midiInReset(IntPtr hmi);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiInStart")]
        public static extern int midiInStart(IntPtr hmi);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiInMessage")]
        public static extern int midiInMessage(IntPtr hmi, int uMsg, int dw1, int dw2);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiInAddBuffer")]
        public static extern int midiInAddBuffer(IntPtr hmi, ref midihdr pmh, int cbmh);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiInGetNumDevs")]
        public static extern int midiInGetNumDevs();

        [DllImportAttribute("winmm.dll", EntryPoint = "midiInGetDevCapsW")]
        public static extern int midiInGetDevCapsW([MarshalAsAttribute(UnmanagedType.SysUInt)] int uDeviceID, ref MIDIINCAPSW pmic, int cbmic);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiInGetErrorTextW")]
        public static extern int midiInGetErrorTextW(int mmrError, [MarshalAsAttribute(UnmanagedType.LPWStr)] System.Text.StringBuilder pszText, int cchText);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiInPrepareHeader")]
        public static extern int midiInPrepareHeader(IntPtr hmi, ref midihdr pmh, int cbmh);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiInUnprepareHeader")]
        public static extern int midiInUnprepareHeader(IntPtr hmi, ref midihdr pmh, int cbmh);






        [DllImportAttribute("winmm.dll", EntryPoint = "midiOutGetNumDevs")]
        public static extern int midiOutGetNumDevs();

        [DllImportAttribute("winmm.dll", EntryPoint = "midiOutOpen")]
        public static extern int midiOutOpen(ref IntPtr phmo, int uDeviceID, int dwCallback, int dwInstance, int fdwOpen);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiOutClose")]
        public static extern int midiOutClose(IntPtr hmo);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiOutGetID")]
        public static extern int midiOutGetID(IntPtr hmo, ref int puDeviceID);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiOutReset")]
        public static extern int midiOutReset(IntPtr hmo);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiOutLongMsg")]
        public static extern int midiOutLongMsg(IntPtr hmo, ref midihdr pmh, int cbmh);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiOutMessage")]
        public static extern int midiOutMessage(IntPtr hmo, int uMsg, int dw1, int dw2);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiOutShortMsg")]
        public static extern int midiOutShortMsg(IntPtr hmo, int dwMsg);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiOutGetVolume")]
        public static extern int midiOutGetVolume(IntPtr hmo, ref int pdwVolume);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiOutSetVolume")]
        public static extern int midiOutSetVolume(IntPtr hmo, int dwVolume);


        [DllImportAttribute("winmm.dll", EntryPoint = "midiOutGetDevCapsW")]
        public static extern int midiOutGetDevCapsW([MarshalAsAttribute(UnmanagedType.SysUInt)] int uDeviceID, ref MIDIOUTCAPSW pmoc, int cbmoc);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiOutCachePatches")]
        public static extern int midiOutCachePatches(IntPtr hmo, int uBank, ref ushort pwpa, int fuCache);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiOutGetErrorTextW")]
        public static extern int midiOutGetErrorTextW(int mmrError, [MarshalAsAttribute(UnmanagedType.LPWStr)] System.Text.StringBuilder pszText, int cchText);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiOutPrepareHeader")]
        public static extern int midiOutPrepareHeader(IntPtr hmo, ref midihdr pmh, int cbmh);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiOutUnprepareHeader")]
        public static extern int midiOutUnprepareHeader(IntPtr hmo, ref midihdr pmh, int cbmh);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiOutCacheDrumPatches")]
        public static extern int midiOutCacheDrumPatches(IntPtr hmo, int uPatch, ref ushort pwkya, int fuCache);





        [DllImportAttribute("winmm.dll", EntryPoint = "midiStreamOut")]
        public static extern int midiStreamOut(IntPtr hms, ref midihdr pmh, int cbmh);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiStreamOpen")]
        public static extern int midiStreamOpen(ref IntPtr phms, ref int puDeviceID, int cMidi, int dwCallback, int dwInstance, int fdwOpen);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiStreamClose")]
        public static extern int midiStreamClose(IntPtr hms);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiStreamRestart")]
        public static extern int midiStreamRestart(IntPtr hms);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiStreamStop")]
        public static extern int midiStreamStop(IntPtr hms);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiStreamPause")]
        public static extern int midiStreamPause(IntPtr hms);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiStreamPosition")]
        public static extern int midiStreamPosition(IntPtr hms, ref mmtime_tag lpmmt, int cbmmt);

        [DllImportAttribute("winmm.dll", EntryPoint = "midiStreamProperty")]
        public static extern int midiStreamProperty(IntPtr hms, ref byte lppropdata, int dwProperty);

    }
}
