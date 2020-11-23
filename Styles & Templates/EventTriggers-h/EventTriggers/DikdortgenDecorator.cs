using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace EventTriggers
{ //decarator classı. Concrete decaratorler bunu inherit eder.
    public class DikdortgenDecorator : IDikdortgen
    {
        private IDikdortgen _dikdortgen; 

        public DikdortgenDecorator(IDikdortgen dikdortgen)
        {
            _dikdortgen = dikdortgen;
        }

        public virtual int getBoyut()
        {
            return _dikdortgen.getBoyut();
        }

        public virtual Brush getRenk()
        {
            return _dikdortgen.getRenk();
        }
    }
}