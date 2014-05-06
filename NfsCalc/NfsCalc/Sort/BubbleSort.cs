﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NfsCalc;
namespace NfsCalc.Sort
{
    public class BubbleSort:ISortOperation
    {
     
        public int[] Sort(int[] array)
            {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
                {
                for (int j = 0; j < array.Length - i - 1; j++)
                    {
                    if (array[j] > array[j + 1])
                        {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        }
                    }
                }   
                return array;
            }
     }
}
