using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCsharp
{
    public class ClassTryCatch
    {
        public void Func1()
        {
            try
            {
                throw new ArithmeticException("Func1 Exception");
            }
            finally
            {

            }
        }

        public void Func2()
        {
            try
            {
                
            }
            finally
            {
                throw new ArithmeticException("Func2 Exception");
            }
        }

        public void Func3()
        {
            try
            {
                throw new ArithmeticException("Func3 Exception");
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
        }


        public void Func4()
        {
            try
            {
                return;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                string str = "Func4 Final";
                throw new Exception(str);
            }
        }

        public void Func5()
        {
            try
            {
                //int i =  0;
                //int j = 10 / i;

                int[] iarr = new int[3];
                iarr[0] = 10;
                iarr[1] = 20;
                iarr[2] = 30;
                //iarr[3] = 40;

                Person onjP = null;
                onjP.Name = "Ankit";
            }
            catch (ArithmeticException exc1)
            {

            }
            catch (IndexOutOfRangeException exc2)
            {

            }
            catch (NullReferenceException exc3)
            {

            }
            finally
            {
                string str = "Func4 Final";
                throw new Exception(str);
            }
        }

    }
}
