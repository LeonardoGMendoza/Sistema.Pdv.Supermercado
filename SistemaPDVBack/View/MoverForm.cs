
using System.Runtime.InteropServices;
using System;
namespace SistemaPDVBack
{
    class MoverForm
    {
            [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
             public extern static void ReleaseCapture();
            [DllImport("user32.DLL", EntryPoint = "SendMessage")]
             public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
         
                
    }
}
