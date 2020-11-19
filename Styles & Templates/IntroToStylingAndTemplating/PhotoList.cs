// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.ObjectModel;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;


namespace IntroToStylingAndTemplating
{
    public class PhotoList : ObservableCollection<Photo>, ISubject
    {
        //Uygulamada PhotoList bir Subject (Observable).

        UpdateList guncelle;

        private List<Observer> observers;  //Observerlarýn tutulduðu liste bu olacak.
        public PhotoList()
        {
            observers = new List<Observer>(); //Constructor'da observer listesini oluþturduk. 
        }
        public void AddObserver(Observer o)
        {
            observers.Add(o);
        }

        public void DeleteObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void notifyObservers()
        {
            //Burada foreach döngüsüyle bütün observerlarýn update fonksiyonu çaðrýlacak

            foreach(Observer observer in observers)
            {
                observer.Update(this);
            }
        }


        public void setUpdateMethod(UpdateList up)
        {
            guncelle = up;
        }
        public void GetUpdates()
        {
            guncelle.Update(this);
            notifyObservers();
        }

        #region var olan kodlar 
        //Var olan kodlar
        private DirectoryInfo _directory;
         
        public PhotoList(string path) : this(new DirectoryInfo(path))
        {

        }

        public PhotoList(DirectoryInfo directory)
        {
            _directory = directory;
            Update();
        }

        public string Path
        {
            set
            {
                _directory = new DirectoryInfo(value);
                Update();
            }
            get { return _directory.FullName; }
        }

        public DirectoryInfo Directory
        {
            set
            {
                _directory = value;
                Update();
            }
            get { return _directory; }
        }    
        public void Update()
        {
            foreach (var f in _directory.GetFiles("*.jpg"))
            {
                Add(new Photo(f.FullName));
             
            }
        }
        //Var olan kodlar
    }
    #endregion
}