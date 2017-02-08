using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rappisolution
{
    class Program
    {
        static void Main(string[] args)
        {

            CubeSummation cube = new CubeSummation();
            int data1 = 2;
            string data2 = "4 5";
            long sum = 0;
            cube.CubeSummationx(data1, data2, sum);
            Console.ReadLine();
        }
    }
}
