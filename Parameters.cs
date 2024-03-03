using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTREALISE.Drag
{
    internal class Parameters
    {
        private const int WM = 0xA1;
        private const int HT = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lPraram);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        internal void get()
        {
            ReleaseCapture();

        }
        internal void sebnd(IntPtr q, int w, int e, int r)
        {
            w = WM; e = HT;
            SendMessage(q, w, e, r);
        }
    }
}
