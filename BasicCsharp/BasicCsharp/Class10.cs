using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace BasicCsharp
{
    public class Class10
    {
        public int Add(int Num1)
        {
            return Num1;
        }

        public int Add(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        public int multiply(int Num1, int Num2 = 1)
        {
            return Num1 * Num2;
        }

        //optional must appear after all required
        public int multiply(int Num1, int Num2 = 1, int num3 = 2)
        {
            return Num1 + Num2;
        }

        //in case keyword above rule is not applicable
        public int Add(int Num1, int Num2,int num3,[Optional] int num4)
        {
            return Num1 + Num2 + num3 + num4;
        }

        // param must be single dimentional array
        // can be list or dict
        // it should be last param
        public int Add(int firstNumber, params int[] numbers)
        {
            int temp = 0;
            foreach (int tempNum in numbers)
            {
                temp += tempNum;
            }
            return temp + firstNumber;
        }

        public void MainMethod()
        {
            Add(12);
            Add(12, 13);
        }
    }
}
