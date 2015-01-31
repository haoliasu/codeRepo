using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace multiThread
{
    class Program
    {
        public delegate void del(int a,int b,int[] arr);

        static void Main(string[] args)
        {
            int[] arr=new int[10];
           // public delegate void del(int a);
            del maniDel=manipulate;
           Thread th1 = new Thread(Program.manipulate(int oper, int byNum, int[] array));
            //public delegate void 
                
        }
    
    
        
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
