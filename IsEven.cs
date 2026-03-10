using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    public static class ExtentionMethods
    {

        public static bool IsEven(this int input)
        {
            bool result;
            if (input % 2 == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
