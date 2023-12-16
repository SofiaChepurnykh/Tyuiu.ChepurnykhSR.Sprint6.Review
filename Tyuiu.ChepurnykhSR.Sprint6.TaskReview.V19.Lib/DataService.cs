using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ChepurnykhSR.Sprint6.TaskReview.V19.Lib
{
    public class DataService
    {
        public int GetMatrix(int [,] array, int c, int k, int l)
        {
            int count = 0;
            for (int j = k - 1; j <= l - 1; j++)
            {
                if (array[c - 1, j] % 2 == 0) 
                {
                    count++;
                }
            }
            return count;
        }
    }
}
