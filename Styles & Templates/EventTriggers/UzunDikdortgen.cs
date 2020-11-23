using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Media;
namespace EventTriggers
{
    class UzunDikdortgen : DikdortgenDecorator
    {
        public UzunDikdortgen(IDikdortgen dikdortgen) : base(dikdortgen)
        {
            
        }

        // uzunluğu dekore ederken renk olduğu gibi kalır
        public override Brush getRenk()
        {
            return base.getRenk();
        }

        //uzunluğu dekore etmek için boyunu 20 arttrıyoruz
        public override int getBoyut()
        {
            int newBoyut = base.getBoyut() + 20;
            return newBoyut;
        }
    }
}