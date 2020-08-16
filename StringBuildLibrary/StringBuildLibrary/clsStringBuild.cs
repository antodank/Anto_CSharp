using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuildLibrary
{
    public class clsStringBuild
    {

        public string combineStringArrayToLine(string[] stringArray)
        {
            string str = string.Empty ;

            if (stringArray != null)
            {
                foreach (string item in stringArray)
                {
                    if (item.Trim().Length > 0)
                        str += item.Trim() + " ";
                }
            }
            
            
            return str.Trim() ;
        }
    }
}
