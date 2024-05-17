using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pattern();
            Console.WriteLine();
            pattern1();
            Console.WriteLine();
            pattern2();
            Console.WriteLine();
            pattern3();
            Console.WriteLine();
            pattern4();
            Console.WriteLine();
            pattern5();
        }

        public static void pattern()
        {
            int i, j, n = 5;

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }


        public static void pattern1()
        {
            int i, j, n = 5;

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        public static void pattern2()
        {
            int i, j, n = 5, k=1;

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(k + " ");
                    k++;
                }
                Console.WriteLine();
            }
        }


        public static void pattern3()
        {
            int i, j, n = 5;

            for(i = 1; i <= n;i++)
            {
                int k = i;
                for(j = 1; j <= i;j++)
                {
                    Console.Write(k + " ");
                    k++;
                }
                Console.WriteLine();
            }
        }


        public static void pattern4()
        {
            int i, j, n = 5;
            
            for( i = 1; i <= n; i++)
            {
                for(j = i; j <= n; j++)
                {
                    Console.Write(" ");
                }
                for(j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            
        }


        public static void pattern5()
        {
            int i, j, n = 5;
            //int k = 1;

            for (i=1; i <= n; i++)
            {
                int k = 1;
                for( j = i; j <= n; j++)
                {
                    Console.Write(" ");
                }

                
                for( j = 1; j <= i; j++)
                {
                    Console.Write(k + " ");
                    k = k * (i - j) / j;
                }

                Console.WriteLine();
            }
        }
    }
}
