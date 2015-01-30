using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiThread
{
    class Program
    {
        
        static void Main(string[] args)
        {

        }
    }
    public class manipulateNumInArray
    {
        public static void manipulate(int oper, int byNum, int[] array)
        {
            switch (oper)
            { 
                case 0:
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = addTo(array[i], byNum);
                    }
                   break;

                case 1:
                   for (int i = 0; i < array.Length; i++)
                   {
                       array[i] = multi(array[i], byNum);
                   }
                    break;
                default:
                    break;

            }
        }
        public static int addTo(int input,int adder)
        {
            return input + adder;
        }

        public static int multi(int input, int adder)
        {
            return input * adder;
        }






    }
}
