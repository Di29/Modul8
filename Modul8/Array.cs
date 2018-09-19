using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8
{
    public class Array
    {
        private int[] Aray;
        public int this[int index]
        {
            get
            {
                return Aray[index];
            }

            set
            {
                Aray[index] = (int)Math.Pow(value, 2);
            }
        }

        public Array(int size)
        {
            Aray = new int[size];
        }
    }
}
