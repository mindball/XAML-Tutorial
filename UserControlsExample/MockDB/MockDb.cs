using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace UserControlsExample.MockDB
{
    public class MockDb
    {        
        public static BitmapImage GetPostPicture()
        {
            List<string> filePaths = 
                Directory
                .GetFiles(Environment.CurrentDirectory + @"\..\..\Icons", "*.jpg")
                .ToList<string>();

            Random random = new Random();
            FileInfo myRandomFile = new FileInfo(filePaths[random.Next(filePaths.Count())]);

            return new BitmapImage(new Uri(myRandomFile.FullName, UriKind.RelativeOrAbsolute));
        }

        public static Uri GetPostVideo()
        {
            return new Uri(Environment.CurrentDirectory + @"\..\..\Videos\cat.mp4", UriKind.RelativeOrAbsolute);
        }


    }
}
