using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IntroToStylingAndTemplating
{
    public class AddPhoto : UpdateList
    {
        public void Update(PhotoList list)
        {
            string filePath = @"C:\Users\lenovo\Documents\GitHub\WPF-Samplesfork\Styles & Templates\IntroToStylingAndTemplating\images\a\dance.jpg";
            string targetPath = @"C:\Users\lenovo\Documents\GitHub\WPF-Samplesfork\Styles & Templates\IntroToStylingAndTemplating\images\dance.jpg";

            File.Copy(filePath, targetPath, true);

            Photo foto = new Photo(filePath);
            list.Add(foto);
        }
    }
}
