using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.CodeDom;

namespace experiments.Services
{
    class ServiceCCDCamera
    {
        //const string PMSDLLNAME = "vslib3.dll";
        const string PMSDLLNAME = "vscorelib_v4.dll";
        private bool _ErrorD;
        char Name;
        //private string[] _listIds;


        /*[DllImport("vslib3.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        
        public static extern char VsLib3Version();
        public static extern int VsLib3Init(bool _ErrorD);

        [DllImport("vslib3.dll")]
        public static extern uint VsLib3ListGetStdList(uint ListId);*/
        /*[DllImport(PMSDLLNAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern short VsLib3Version();

        [DllImport(PMSDLLNAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern int VsLib3Init(bool ErrorD);

        [DllImport(PMSDLLNAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern int VsLib3GetObjectId(uint OwnerObjId, char Name, uint ObjId, bool ErrorD);


        public ServiceCCDCamera()
        {
            var versionLib = VsLib3Version();
            MessageBox.Show(versionLib.ToString());
            var k = VsLib3Init(_ErrorD);
            MessageBox.Show("k="+k.ToString());
            var l = VsLib3GetObjectId(0, Name, 0, _ErrorD);
            MessageBox.Show("l=" + l.ToString());
            
            //int ids = VsLib3ListGetAll();

        }*/

        #region Linkin

        [DllImport(PMSDLLNAME, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetEnvironment")]
        static extern short GetEnvironment();

        [DllImport(PMSDLLNAME, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetDevicePrototypes")]
        static extern int GetDevicePrototypes();

        [DllImport(PMSDLLNAME, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetSettings")]
        static extern short GetSettings();

        [DllImport(PMSDLLNAME, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetCurrent")]
        static extern short GetCurrent();

        [DllImport(PMSDLLNAME, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetDeviceCreator")]
        static extern short GetDeviceCreator(short device);
        
        [DllImport(PMSDLLNAME, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Create")]
        static extern short Create();
        
        #endregion
        

        public ServiceCCDCamera()
        {
            var pEnv = GetEnvironment();
            MessageBox.Show(pEnv.ToString());
            //var k = GetSettings();
            //MessageBox.Show(k.ToString());
            var devices = GetDevicePrototypes();
            var device = GetCurrent();
            GetDeviceCreator(device);
            Create();
        }
    }
}
