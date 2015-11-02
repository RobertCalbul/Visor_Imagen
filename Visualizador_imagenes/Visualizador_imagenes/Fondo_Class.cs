using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Visualizador_imagenes
{
    class Fondo_Class
    {
        private const uint SPI_SETDESKWALLPAPER = 20;
        private const uint SPIF_UPDATEINIFILE = 0x01;
        private const uint SPIF_SENDWINICHANGE = 0x02;
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fwinIni);

        public static void SetDesktopWallpaper(string path) {
            if (!SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWINICHANGE)) {
                throw new Win32Exception();
            }
        }
    }
}
