using System;
using System.IO;
using System.Text;

namespace BusinessLayer.Controller
{
    public static class FilController
    {
        private static string fileName = "podcasts.xml";

        public static void EnsureFileExists()
        {
            string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string filePath = Path.Combine(desktopFolder, fileName);

            if (!File.Exists(filePath))
            {
                using (FileStream fs = File.Create(filePath))
                {
                    string xmlContent = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n<Podcasts></Podcasts>";
                    byte[] info = new UTF8Encoding(true).GetBytes(xmlContent);
                    fs.Write(info, 0, info.Length);
                }
            }
        }

        public static string GetFilePath()
        {
            string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            return Path.Combine(desktopFolder, fileName);
        }
    }
}
