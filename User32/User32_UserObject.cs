using System;
using System.Runtime.InteropServices;

namespace TOAPI.User32
{
    public partial class User32
    {
        // Desktops and Window Sessions
        // GetUserObjectInformation
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetUserObjectInformation(IntPtr hObj, int nIndex, [Out] byte[] pvInfo, int nLength, out uint lpnLengthNeeded);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        public static extern bool GetUserObjectInformation([In] IntPtr hObj, int nIndex, IntPtr pvInfo, int nLength, IntPtr lpnLengthNeeded);


        public static int GetUserObjectInformationW([In] IntPtr hObj, int nIndex, object pvInfo, uint nLength, IntPtr lpnLengthNeeded)
        {
            uint flagsLength;
            IntPtr lengthNeeded = IntPtr.Zero;
            int retValue;

            // First figure out how much length is needed
            retValue = GetUserObjectInformationW(hObj, UOI_FLAGS, IntPtr.Zero, 0, lengthNeeded);

            // Set the length to the length needed
            flagsLength = (uint)lengthNeeded.ToInt32();

            // Now make the call again with the right size and structure
            GCHandle h0 = GCHandle.Alloc(pvInfo, GCHandleType.Pinned);
            try
            {
                retValue = GetUserObjectInformationW(hObj, UOI_FLAGS, h0.AddrOfPinnedObject(), flagsLength, lengthNeeded);
            }
            finally
            {
                h0.Free();
            }

            return retValue;
        }

        // GetUserObjectSecurity
        [DllImport("user32.dll", EntryPoint = "GetUserObjectSecurity")]
        public static extern int GetUserObjectSecurity([System.Runtime.InteropServices.InAttribute()] IntPtr hObj, [In] ref uint pSIRequested, System.IntPtr pSID, uint nLength, [System.Runtime.InteropServices.OutAttribute()] out uint lpnLengthNeeded);

        // SetUserObjectInformation
        [DllImportAttribute("user32.dll", EntryPoint = "SetUserObjectInformationW")]
        public static extern bool SetUserObjectInformationW([In] IntPtr hObj, int nIndex, [In] IntPtr pvInfo, uint nLength);

        // SetUserObjectSecurity
        [DllImportAttribute("user32.dll", EntryPoint = "SetUserObjectSecurity")]
        public static extern bool SetUserObjectSecurity([In] System.IntPtr hObj, [In] ref uint pSIRequested, [In] IntPtr pSID);

    }
}
