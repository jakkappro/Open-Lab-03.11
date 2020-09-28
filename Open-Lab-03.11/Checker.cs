using System;
using System.Linq;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            char[] originalStr = str.ToCharArray();
            string reverseStr = "";
            
            for(int i = originalStr.Length - 1; i >= 0; i--)
            {
                reverseStr += originalStr[i];
            }


            if(str == reverseStr)
            {
                return true;
            }

            return false;
        } 
    }
}
