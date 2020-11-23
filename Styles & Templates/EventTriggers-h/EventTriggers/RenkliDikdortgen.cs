using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Media;


namespace EventTriggers
{
    class RenkliDikdortgen : DikdortgenDecorator
    {
        public RenkliDikdortgen(IDikdortgen dikdortgen) : base(dikdortgen)
        {
            
        }
        public override Brush getRenk()
        {
            return Brushes.Red;
        }
        public override int getBoyut()
        {
            return base.getBoyut();
        }
    }
}
