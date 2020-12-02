// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace EventTriggers
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void addRectangle(object sender, RoutedEventArgs e)
        {
            IDikdortgen dikdortgen = new Dikdortgen();

            if (rU.IsChecked == true)
            {
                dikdortgen = new UzunDikdortgen(dikdortgen);
            }
            if (rR.IsChecked == true)
            {
                dikdortgen = new RenkliDikdortgen(dikdortgen);
               
            }
            //if (rR.IsChecked == true && rU.IsChecked == true)
            //{
            //    dikdortgen = new RenkliDikdortgen(new UzunDikdortgen(new Dikdortgen()));
            //}

            //arayüzde en alttaki dikdörtgene Name="kare" yazdım. Yukarda yaratılan dikdörtgenin özelliklerini o kareye verdim
            kare.Width = dikdortgen.getBoyut();
            kare.Fill = dikdortgen.getRenk();
            MessageBox.Show("Kare " + kare.Width.ToString() + " boyunda ve " + kare.Fill.ToString() + " renginde dekore edildi.");

        }
    }
}