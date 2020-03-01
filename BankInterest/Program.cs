using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankInterest
{
    class Program
    {
        public static double Calculate(string userInput)
        {
            string[] elements = userInput.Split(' ');
            double s = Convert.ToDouble(elements[0]);
            double r = Convert.ToDouble(elements[1]);
            int n = Convert.ToInt32(elements[2]);            
            double p = 1 + (r / 12.0) / 100.0;
            return s*Math.Pow(p,n);
        }
        static void Main(string[] args)
        {
            string userInput;
            userInput = Console.ReadLine();
            double deposit;
            deposit = Calculate(userInput);
            Console.WriteLine(deposit);
            Console.ReadKey();
        }
    }
}
