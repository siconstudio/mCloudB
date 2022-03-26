using System;
using System.Drawing;
using System.IO;

namespace mCloudB.services.api
{
    internal class imgCryptor
    {
        public byte[] ReadImageFile(string imageLocation)
        {

            byte[] imageData = null;

            if (imageLocation != string.Empty)
            {
                if (imageLocation != null)
                {
                    FileInfo fileInfo = new FileInfo(imageLocation);

                    long imageFileLength = fileInfo.Length;

                    FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);

                    BinaryReader br = new BinaryReader(fs);

                    imageData = br.ReadBytes((int)imageFileLength);
                }
            }

            return imageData;
        }

        public Image GetImageFromDB(object dt)
        {
            Image image = null;
            if (dt != DBNull.Value || dt.ToString() != "")
            {
                Byte[] img = new byte[0];
                img = (Byte[])dt;
                MemoryStream MS = new MemoryStream(img);
                MS.Position = 0;
                return Image.FromStream(MS);
            }
            return image;
        }
    }
}
