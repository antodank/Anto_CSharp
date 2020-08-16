using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EnumTypes
    {
        //  An enum is a distinct value typewith a set of named constants
        // The default underlying type is int which starts  with 0 and increased by 1
        // mostly use for comparing in wsitch case 
        public enum Days
        {
           SUN = 0,
           MON,
           TUE,
           WED,
           THR,
           FRI,
           SAT

        }

        public enum Severity
        {
            Danger = 10,
            High = 8,
            Avaerage = 5,
            Good = 6,
            Poor = 2

        }

        public enum ColorCode
        {
            RED = 'R',
            GREEN = 'G',
            Blue = 'B',
        }


    }
}
