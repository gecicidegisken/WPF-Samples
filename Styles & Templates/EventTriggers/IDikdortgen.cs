using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;


namespace EventTriggers
{
    //ne kadar dekore edilirse edilsin sonuç olarak elimizdeki dikdörtgen yine de dikdörtgen kalacak
    public interface IDikdortgen
    {
        int getBoyut();
        Brush getRenk();
    }
}
