using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Media;

namespace EventTriggers
{    // bu somut (concrete) dikdörtgenin üretildiği class
    public class Dikdortgen : IDikdortgen
    {
        public int getBoyut()
        {
            return 50;
        }

        public Brush getRenk()
        {
            return Brushes.Blue;
        }
    }
}
