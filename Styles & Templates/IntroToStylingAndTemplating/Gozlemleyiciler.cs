using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToStylingAndTemplating
{
    //observerların genel özellikleri ve field'larını bir base class'tan almalarını istedik. Böylece her observer
    //tek tek field ve method tanımlayamayacak.
    // stringObserver ve countObserver diye observerlar olacak. Her biri Subject'ten aldıkları bilgiyi farklı 
    //şekillerde işleyecek
  public  class Gozlemleyiciler
    {
       public List<string> observerData = new List<string>();

        public virtual string Display()
        {
            return "";
        }
    }
}
