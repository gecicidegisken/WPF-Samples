using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToStylingAndTemplating
{
 public class RemovePhoto : UpdateList
    {
      //0.inedx'teki fotoğraf kaldırılıyor
        public void Update(PhotoList list)
        {

            list.RemoveAt(0);
           
        }
            
      
    }
}

