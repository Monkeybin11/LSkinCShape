using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;


    public static class DebugTool
    {
        public static bool IsDesignMode
        {
            get {
                bool returnFlag = false;
#if DEBUG
                if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                {
                    returnFlag = true;
                }
                else if (Process.GetCurrentProcess().ProcessName == "devenv")
                {
                    returnFlag = true;
                }
#endif

                return returnFlag;
            }
        }

    }
