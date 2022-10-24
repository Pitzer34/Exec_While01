using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1+ 2 + 3 + 4 + .... + N <105,請問 N 是多少 ?

            int number = 1;
            int sum = 105;
            while (sum >0)
            {
                number += 1;
                sum -= number;
            	
            }
            Console.WriteLine(number-1);
        }
        
    }
}
