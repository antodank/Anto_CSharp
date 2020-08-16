using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAlgos
{
    public class Problem1
    {

        public string toBinary(int num)
        {
            string result = string.Empty;
            while(num > 0)
            {

                int reminder = num % 2;
                result = result + reminder.ToString();
                num = num / 2;
            }

            return result;
        }

        public bool isPowerNum(int num, int power)
        {
            if (power == 0 || num == 0)
                return false;

            while(num != 1)
            {
                if (num % power == 0)
                    num = num / power;
                else
                    return false;
            }

            return true;
        }

        public string binaryAdd(int a,int b)
        {
            int result = (a & b);
            return result.ToString();
        }

    }
}
