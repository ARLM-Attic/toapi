﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TOAPI.HID
{
    public partial class HID_Constants
    {
        //  API declarations for HID communications.

        //  from hidpi.h
        //  Typedef enum defines a set of integer constants for HidP_Report_Type

        internal const Int16 HidP_Input = 0;
        internal const Int16 HidP_Output = 1;
        internal const Int16 HidP_Feature = 2;

    }
}
