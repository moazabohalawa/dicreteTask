using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number one");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number two");
            int num2 = int.Parse(Console.ReadLine());

            for (int primenum=num1; primenum<=num2; primenum++)
            {
                int ifvariable = 0;
                for(int vloop =1;vloop <= primenum;vloop++)
                {
                    if(primenum % vloop == 0)
                    {
                        ifvariable++;
                    }
                }
                if (ifvariable == 2)
                {
                    Console.WriteLine("prime number is:" + primenum);
                }
            }


        }
    }
}
