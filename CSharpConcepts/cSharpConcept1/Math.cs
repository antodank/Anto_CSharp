using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpConcept1
{
    class Math
    {
       

        public void division()
        {
            var oa = 5;
            var ob = 10;
            var oc = oa + ob;
            var od = 5 + 10;

            var oe = new Pet();
            //var of = oa + oe; // compile time error

            var og = "Ankit";
            var oh = oa + og;

            dynamic da = 20;
            dynamic db = new Pet();

            //dynamic dc = da + db; // run time error


            string msg = string.Empty;  
            try
            {
                Pet objPetA = db as Pet;
                Pet objPetB = (Pet)db;

                Pet objPetC = da as Pet;
                Pet objPetD = (Pet)da;
 
                try
                {
                    int a = 5; int b = 0;
                    int c = a / b;
                }
                catch (DivideByZeroException edvinner)
                {
                    msg = edvinner.StackTrace + Environment.NewLine; 
                    Console.WriteLine("Inner DivideByZeroException");  
                    //throw;
                    throw new Exception("My Error"); 
                }
                catch (Exception einner)
                {
                    Console.WriteLine("Inner Exception");  
                    throw;
                }
            }
            catch (DivideByZeroException edvouter)
            {
                msg += edvouter.StackTrace + Environment.NewLine;   
                Console.WriteLine("Outer DivideByZeroException");
            }
            catch (Exception eouter)
            {
                msg += eouter.StackTrace;  
                Console.WriteLine("Outer Exception");  
            }
        }
    }
}
