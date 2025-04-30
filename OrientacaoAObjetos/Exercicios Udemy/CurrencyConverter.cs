using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOO.Exercicios_Udemy
{
    public class CurrencyConverter
    {
        
        public static double IOF = 0.06;
        public static double dollarToReal(double amount, double dollarPrice)
        {
            return amount * dollarPrice * (1.0 + IOF);
        }

        //Console.WriteLine("Whats is the dollar price?!");
        //    double dollarPrice = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("How many dollars will be bought?!");
        //    double amount = Convert.ToDouble(Console.ReadLine());
        //double result = CurrencyConverter.dollarToReal(dollarPrice, amount);
        //Console.WriteLine("Amount to be paid in reais = ", result);

    }

    
}
