using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBarcodeScanner
{
    internal interface InterfaceSannerCallback
    {

        Boolean initialize();
        Boolean is_processable(Bitmap input);
        object result(Bitmap input);


    }

}
