using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SchoolProject.Assests
{
    class ImageDeal
    {
        public static Image GetBrowserImage()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose image";
            ofd.Filter = "Image Files |*.jpg; *.png; *.gif;";
            Image im = null;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                im = Image.FromFile(ofd.FileName);
            }
            return im;
        }
        public static Byte[] imageToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            return ms.ToArray();
        }
        public static Image ByteArrayToImage(Byte[] bytes)
        {

            MemoryStream ms = new MemoryStream(bytes);
            Image returnImage = Image.FromStream(ms);
            return returnImage;

        }
    }
}
