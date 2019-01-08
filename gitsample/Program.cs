using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitsample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(palindrome(141));
        }
        public static bool palindrome(int n)
        {
            bool flag = true;
            int reverse = 0;
            int rem;
            int temp = n;
            while (n > 0)
            {

                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            if (temp == reverse)
            {
                return flag;
            }
            else
            {
                return false;
            }
        }
    }
}
