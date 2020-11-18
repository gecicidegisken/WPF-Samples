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

        public void Update(string p)
        {
            this.observerData.Add(p);
            
        }

        public override string Display()
        {
            string newest = "";
            foreach (string s in observerData)
            {
                newest =newest + s + "\n";
             }
            return newest;
        }
    }
}
