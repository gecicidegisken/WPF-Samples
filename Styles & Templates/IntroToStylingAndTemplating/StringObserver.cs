using System.Collections.ObjectModel;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Data;


namespace IntroToStylingAndTemplating
{
    //StringObserver PhotoList'teki fotoğrafların path'lerini gösterir
    public class StringObserver : Gozlemleyiciler, Observer
    {

        public void Update(PhotoList list)
        {
            foreach (Photo e in list)
                this.observerData = list;

        }

        public override string Display()
        {
            string newest = "";
            foreach (Photo s in observerData)
            {
                newest =newest + s.Source + "\n";
             }
            return newest;
        }
    }
}
