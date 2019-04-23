using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(123, 155);
                Console.WriteLine(ContaCorrente.TaxaOperacao);
            } catch(ArgumentException e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            } catch (DivideByZeroException e)
            {
                Console.WriteLine("A quantidade de contas era zero, a taxa é integra: 30,00");
            }

            Console.ReadLine();
        }
    }
}
