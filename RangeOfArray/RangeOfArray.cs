using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeOfArray
{
    public class RangeOfArray
    {
        private int minDiapason;
        private int maxDiapason;

        int[] array;



        public RangeOfArray(int firstBorder, int secondBorder)
        {
            this.minDiapason = firstBorder;
            this.maxDiapason = secondBorder;

            if (firstBorder > secondBorder) array = new int[firstBorder - secondBorder];
            else array = new int[secondBorder - firstBorder];
        }

        public int this[int index]
        {
            set
            {
                if (minDiapason < maxDiapason)
                {
                    if (index < minDiapason || index > maxDiapason) throw new IndexOutOfRangeException("Выход из границ массива");
                    array[index - minDiapason] = value;
                }
                else
                {
                    if (index > minDiapason || index < maxDiapason) throw new IndexOutOfRangeException("Выход из границ массива");
                    array[index - maxDiapason] = value;
                }
            }
            get
            {
                if (minDiapason < maxDiapason)
                {
                    if (index < minDiapason || index > maxDiapason) throw new IndexOutOfRangeException("Выход из границ массива");
                    return array[index - minDiapason];
                }
                else
                {
                    if (index > minDiapason || index < maxDiapason) throw new IndexOutOfRangeException("Выход из границ массива");
                    return array[index - maxDiapason];
                }
            }
        }
    }
}
