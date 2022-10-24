using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //使用 while , 在畫面顯示所有可以整除 300 的整數
            //例如: 1, 2, 3, 4, 5, 6, 10, ...., 300

            int number = 300;
            int i = 1;
            
            while (i <= 300)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
                i += 1;
            }
        }
    }
}
