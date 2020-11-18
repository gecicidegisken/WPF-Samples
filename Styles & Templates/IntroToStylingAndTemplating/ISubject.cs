using System.Collections.ObjectModel;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;
namespace IntroToStylingAndTemplating
{
  public  interface ISubject
    {
        //Bu fonksiyonlar arguman olarak birer Obseerver alacak ve concrete subjectler (PhotoList in this case)
        //bu fonksiyonları implemente edecek.
        public void AddObserver(Observer o);
        public void DeleteObserver(Observer o);
        public void notifyObservers(String T);
        

        
    }
}
