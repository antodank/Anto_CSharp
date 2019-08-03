using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


               


                Console.WriteLine("Enter your amount upto 100");
                string strAmt = Console.ReadLine();
                int userAmt = Convert.ToInt32(strAmt);
                //10 coin region
                int remA = userAmt % 10;
                int numA = userAmt / 10;
                if (remA != 0)
                {
                    ///5coin region
                    int remB = remA % 5;
                    int numB = remA / 5;
                    if (remB == 1)
                    {
                        int remC = remA % 2;
                        int numC = remA / 2;
                        if (remC == 0)
                        {
                            Console.WriteLine("No.of coins of 2 is {0}", numC);
                            Console.WriteLine("No.of of 10 coins are {0}", numA);
                            Console.ReadLine();

                        }
                        Console.WriteLine("Number is invalid");

                    }
                    else if(remB==2)
                    {
                        int numC = remB / 2;
                        int remC = remB % 2;
                        Console.WriteLine("No. Of coins of 2 is {0}", numC);
                        Console.WriteLine("No. Of coins of 5 is {0}", numB);                       
                        Console.WriteLine("no.of coins of 10 is {0}", numA);
                        Console.ReadLine();
                    }
                    else if (remB > 1)
                    {
                        int numC = remB / 2;
                        int remC = remB % 2;
                        if (remC == 0)
                        {
                            Console.WriteLine("No. Of coins of 2 is {0}", numC);
                            Console.WriteLine("no.of coins of 5 is {0}", numB);
                            Console.WriteLine("no.of coins of 10 is {0}", numA);
                            
                            Console.ReadLine();
                        }
                        else 
                        {
                            int remC1 = remA % 2;
                            int numC1 = remA / 2;
                            if (remC1 == 0)
                            {
                                Console.WriteLine("No. Of coins of 2 is {0}", numC1);
                                Console.WriteLine("no.of coins of 10 is {0}", numA);
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Entered number is invalid");
                                Console.ReadLine();
                            }


                        }

                    }
                    else
                    {

                        Console.WriteLine("no of 5 coins are {0}", numB);
                        Console.WriteLine("no of 10 coins are {0}", numA);
                        Console.ReadLine();
                    }



                }
                else
                {
                    Console.WriteLine("No.of of 10 coins are {0}", numA);
                    Console.ReadLine();
                }

            }
        }

        
    }
}
