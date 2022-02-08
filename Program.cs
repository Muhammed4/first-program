using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, toplam;
            Console.WriteLine("Calculate the sum of two numbers:");
            Console.Write("Input number1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            toplam = num1 + num2;
            Console.Write("SONUÇ:" + toplam);

            Console.ReadKey();
        }
    }
}
