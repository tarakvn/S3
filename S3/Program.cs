using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int Fn = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int Sn = int.Parse(Console.ReadLine());
            int sum = Fn + Sn;
            Console.WriteLine("Addition of nimbers: " + sum);
            Console.ReadKey();
        }
    }
}
