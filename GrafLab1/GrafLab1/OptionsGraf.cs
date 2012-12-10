using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrafLab1
{
    class OptionsGraf
    {
        private int sizeWay = 0;
        
        public OptionsGraf(int sizeWay)
        {
           SizeWay = sizeWay;
        } 

        public int SizeWay
        {
            get { return sizeWay; }
            set { sizeWay = value; }
        }
    }
}
