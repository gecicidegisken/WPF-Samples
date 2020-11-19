using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToStylingAndTemplating
{
    //CountObserver PhotoList observerlarından biridir. PhotoList'ten  aldığı bilgiyi fotoğraf sayısını göstermek üzere işler.
    public class CountObserver : Gozlemleyiciler,Observer
    {
        public void Update( PhotoList list)
        {
            foreach (Photo e in list)
                this.observerData = list;
        }

        public override string Display()
        {
            return observerData.Count.ToString();  
        }
    }
}
