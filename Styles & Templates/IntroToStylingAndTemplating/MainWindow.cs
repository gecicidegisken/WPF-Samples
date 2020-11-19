// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows;
using System.Windows.Data;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
using System.IO;
using System;


namespace IntroToStylingAndTemplating
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
       

        private PhotoList _photos = new PhotoList();
        StringObserver stringob = new StringObserver();
        CountObserver countob = new CountObserver();
       
       

        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            _photos = (PhotoList)(Resources["MyPhotos"] as ObjectDataProvider).Data;
            _photos.Path = "images";
            //Observerları ekliyoruz
            _photos.AddObserver(stringob);
            _photos.AddObserver(countob);

            //ilk yüklemede observerlara bilgi verilecek
                _photos.notifyObservers();
            

        }
  

        private void StringBtn_Click(object sender, RoutedEventArgs e)
        {
            label.Content = stringob.Display() + "\n";
        }
        private void CountBtn_Click(object sender, RoutedEventArgs e)
        {
            label.Content = countob.Display() + "\n";
        }

        // fotoğraf ekleme butonu 
        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            //string filePath = @"C:\Users\lenovo\Documents\GitHub\WPF-Samplesfork\Styles & Templates\IntroToStylingAndTemplating\images\a\dance.jpg";
            //string targetPath = @"C:\Users\lenovo\Documents\GitHub\WPF-Samplesfork\Styles & Templates\IntroToStylingAndTemplating\images\dance.jpg";
            //File.Copy(filePath, targetPath, true);
            //Photo foto = new Photo(filePath);         

            _photos.setUpdateMethod(new AddPhoto());
            _photos.GetUpdates();

            MessageBox.Show("Yeni fotoğraf eklendi");
              
            }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
     
            _photos.setUpdateMethod( new RemovePhoto());
            _photos.GetUpdates();


            MessageBox.Show("En baştaki fotoğraf silindi");

        }
    }
    }


