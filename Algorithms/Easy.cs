using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Easy
    {
        public static int SimpleArraySum(int[] ar)
        {
            int result = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                result = result + ar[i];
            }
            return result;
        }
    }
}
