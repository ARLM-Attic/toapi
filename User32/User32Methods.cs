using System;
using System.Runtime.InteropServices;
using System.Text;  // For StringBuilder
using TOAPI.Types;

namespace TOAPI.User32
{
    public partial class User32
    {        
        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(SystemMetric nIndex);


        // Timer Methods
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool KillTimer(IntPtr hwnd, int idEvent);

        [DllImport("user32.dll", EntryPoint = "SetTimer")]
        [return: MarshalAsAttribute(UnmanagedType.SysUInt)]
        public static extern uint SetTimer(IntPtr hWnd, [MarshalAsAttribute(UnmanagedType.SysUInt)] uint nIDEvent, uint uElapse, TimerProc lpTimerFunc);

        [DllImport("user32.dll", EntryPoint = "SetTimer")]
        public static extern IntPtr SetTimer(IntPtr hWnd, IntPtr nIDEvent, uint uElapse, TimerProc lpTimerFunc);


        // MessageBeep
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MessageBeep(int type);

        // MessageBox
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, int type);


        // Hooking
        //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr HOOKPROC(int code, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(int idHook, HOOKPROC lpfn, [In] IntPtr hModuleHandle, int threadId);

        [DllImport("user32.dll", EntryPoint = "UnhookWindowsHookEx", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHookEx([In] IntPtr hhk);


        [DllImport("user32.dll", EntryPoint = "CallNextHookEx")]
        public static extern IntPtr CallNextHookEx([In] IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);


        // Thread process IDs
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);


        [DllImport("user32.dll")]
        private static extern int ToAscii(int uVirtKey, int uScanCode, byte[] lpbKeyState, byte[] lpwTransKey, int fuState);

        
        [DllImport("user32.dll", EntryPoint = "ToAscii")]
        public static extern int ToAscii(int uVirtKey, int uScanCode, [In] IntPtr lpKeyState, [Out] out ushort lpChar, int uFlags);


        [DllImport("user32.dll", EntryPoint = "ToAsciiEx")]
        public static extern int ToAsciiEx(uint uVirtKey, uint uScanCode, [In] IntPtr lpKeyState, [Out] out ushort lpChar, uint uFlags, [In] IntPtr dwhkl);




        [DllImport("user32.dll")]
        public static extern IntPtr CopyIcon([In] IntPtr hIcon);

        [DllImport("user32.dll", EntryPoint = "CreateIconIndirect")]
        public static extern IntPtr CreateIconIndirect([In] ref ICONINFO piconinfo);

        [DllImport("user32.dll", EntryPoint = "GetIconInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo([In] IntPtr hIcon, [Out] out ICONINFO piconinfo);



        // Used for USB device notifications
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr RegisterDeviceNotification(IntPtr hRecipient, IntPtr NotificationFilter, Int32 Flags);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern Boolean UnregisterDeviceNotification(IntPtr Handle);

    }
}
