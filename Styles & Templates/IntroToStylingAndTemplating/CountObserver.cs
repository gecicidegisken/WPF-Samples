using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToStylingAndTemplating
{
    //CountObserver PhotoList observerlarından biridir. PhotoList'ten  alduığı bilgiyi fotoğraf sayısını göstermek üzere işler.
    public class CountObserver : Gozlemleyiciler,Observer
    {
        public void Update(string p)
        {
            this.observerData.Add(p);
        }

        public override string Display()
        {
            return observerData.Count.ToString();
                
            
        }
    }
}
