using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NfsCalc;
namespace NfsCalc.Sort
{
    public class Gnom:ISortOperation
    {
        public int[] Sort(int[] array)
        {
            int tmp;
            int i = 1, k = 2;
            while (i < array.Length)
            {
                if (array[i - 1] <= array[i])
                {
                    i = k;
                    k++;
                }
                else
                {
                     tmp = array[i - 1];
                    array[i - 1] = array[i];
                    array[i] = tmp;
                    i --;
                    if (i == 0)
                    {
                        i = 1;
                        k = 2;
                    }

                }

            }
  //          throw new NotImplementedException();
            return array;
        }
    }
}
