using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace DesktopBarcodeScanner
{
    public partial class ScannerForm : Form
    {

        IBarcodeReader reader;

        int u_capture_area_width, u_capture_area_height;
        int u_result_width, u_result_height;
        int self_width, self_height;


        public ScannerForm()
        {
            InitializeComponent();


            reader = new BarcodeReader();

            LocationChanged += new EventHandler(self_LocationChanged);
            // ResizeEnd += new EventHandler(self_ResizeEnd);

            // u_capture_area_width = u_capture_area.Width;
            // u_capture_area_height = u_capture_area.Height;
            // u_result_width = u_result.Width;
            // u_result_height = u_result.Height;
            // self_width = Width;
            // self_height = Height;

        }
        private Bitmap CaptureArea(double x, double y, double width, double height)
        {
            int ix = Convert.ToInt32(x);
            int iy = Convert.ToInt32(y);
            int iw = Convert.ToInt32(width);
            int ih = Convert.ToInt32(height);

            Bitmap bitmap = new Bitmap(iw, ih);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.CopyFromScreen(ix, iy, 0, 0, new System.Drawing.Size(iw, ih));
                return bitmap;
            }
        }

        private void self_LocationChanged(object sender, EventArgs e)
        {
            var capture_area_screen_pos = PointToScreen(u_capture_area.Location);
            var screenshot = CaptureArea(capture_area_screen_pos.X, capture_area_screen_pos.Y, u_capture_area.Width, u_capture_area.Height);
            var result = reader.Decode(screenshot);
            if (result != null)
            {
                u_result.Text = String.Format("[Type]\r\n{0}\r\n\r\n[Result]\r\n{1}", result.BarcodeFormat.ToString(), result.Text);
            }
            else
            {
                u_result.Text = String.Empty;
            }

        }

        private void self_ResizeEnd(object sender, EventArgs e)
        {
            int width_change = self_width - Width;
            int height_change = self_height - Height;
            u_capture_area.SetBounds(u_capture_area.Location.X, u_capture_area.Location.Y, u_capture_area_width - width_change, u_capture_area_height - height_change / 2);
            u_result.SetBounds(u_result.Location.X, u_result.Location.Y, u_result_width - width_change, u_result_height - height_change / 2);

            u_capture_area_width = u_capture_area.Width;
            u_capture_area_height = u_capture_area.Height;
            u_result_width = u_result.Width;
            u_result_height = u_result.Height;
            self_width = Width;
            self_height = Height;

        }

    }
}
