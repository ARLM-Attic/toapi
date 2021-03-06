﻿using System;
using System.Text;
using System.Runtime.InteropServices;

using TOAPI.Types;

namespace TOAPI.WinMM
{
    public partial class winmm
    {
        // WaveOutBreakLoop
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutBreakLoop")]
        public static extern uint waveOutBreakLoop(IntPtr hwo);

        // WaveOutClose
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutClose")]
        public static extern uint waveOutClose(IntPtr hwo);

        // WaveOutGetDevCaps
        // Use IntPtr because the parameter can be either a device index, or a handle 
        // to an already opened device.
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutGetDevCapsW")]
        public static extern int waveOutGetDevCapsW(IntPtr uDeviceID, ref WAVEOUTCAPSW pwoc, int cbwoc);

        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutGetDevCapsA")]
        public static extern uint waveOutGetDevCapsA(IntPtr uDeviceID, ref WAVEOUTCAPSA pwoc, uint cbwoc);


        // WaveOutGetErrorText
        [DllImportAttribute("winmm.dll", CharSet = CharSet.Auto)]
        public static extern uint waveOutGetErrorText(int mmrError, StringBuilder pszText, int cchText);

        // WaveOutGetID
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutGetID")]
        public static extern int waveOutGetID(IntPtr hwo, ref int puDeviceID);

        // WaveOutGetNumDevs
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutGetNumDevs")]
        public static extern int waveOutGetNumDevs();

        // WaveOutGetPitch
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutGetPitch")]
        public static extern int waveOutGetPitch(IntPtr hwo, ref int pdwPitch);

        // WaveOutGetPlaybackRate
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutGetPlaybackRate")]
        public static extern int waveOutGetPlaybackRate(IntPtr hwo, ref int pdwRate);

        // WaveOutGetPosition
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutGetPosition")]
        public static extern int waveOutGetPosition(IntPtr hwo, ref MMTIME pmmt, int cbmmt);

        // WaveOutGetVolume
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutGetVolume")]
        public static extern int waveOutGetVolume(IntPtr hwo, ref int pdwVolume);

        // WaveOutMessage
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutMessage")]
        public static extern int waveOutMessage(IntPtr hwo, uint uMsg, uint dw1, uint dw2);

        // WaveOutOpen
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutOpen")]
        public static extern int waveOutOpen(ref IntPtr phwo, int uDeviceID, ref WAVEFORMATEX pwfx, WaveAudioProc dwCallback, IntPtr dwInstance, int fdwOpen);

        // WaveOutPause
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutPause")]
        public static extern int waveOutPause(IntPtr hwo);

        // WaveOutPrepareHeader
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutPrepareHeader")]
        public static extern int waveOutPrepareHeader(IntPtr hwo, ref WAVEHDR pwh, int cbwh);

        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutPrepareHeader")]
        public static extern int waveOutPrepareHeader(IntPtr hwo, IntPtr pwh, int cbwh);

        // -- WaveOutProc --
        // WaveOutReset
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutReset")]
        public static extern int waveOutReset(IntPtr hwo);

        // WaveOutRestart
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutRestart")]
        public static extern int waveOutRestart(IntPtr hwo);

        // WaveOutSetPitch
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutSetPitch")]
        public static extern int waveOutSetPitch(IntPtr hwo, int dwPitch);

        // WaveOutSetPlaybackRate
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutSetPlaybackRate")]
        public static extern int waveOutSetPlaybackRate(IntPtr hwo, int dwRate);

        // WaveOutSetVolume
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutSetVolume")]
        public static extern int waveOutSetVolume(IntPtr hwo, int dwVolume);

        // WaveOutUnprepareHeader
        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutUnprepareHeader")]
        public static extern int waveOutUnprepareHeader(IntPtr hwo, ref WAVEHDR pwh, int cbwh);

        [DllImportAttribute("winmm.dll", EntryPoint = "waveOutUnprepareHeader")]
        public static extern int waveOutUnprepareHeader(IntPtr hwo, IntPtr pwh, int cbwh);

        // WaveOutWrite
        [DllImport("winmm.dll", EntryPoint = "waveOutWrite", SetLastError = true)]
        public static extern int waveOutWrite(IntPtr hwo, ref WAVEHDR pwh, int cbwh);

        [DllImport("winmm.dll", EntryPoint = "waveOutWrite", SetLastError = true)]
        public static extern int waveOutWrite(IntPtr hwo, IntPtr pwh, int cbwh);
    }
}
