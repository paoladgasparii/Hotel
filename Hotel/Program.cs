using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor da diária do hotel: ");
            double diaria = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de adultos: ");
            int adultos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de crianças: ");
            int criancas = int.Parse(Console.ReadLine());

            double valordia = (diaria * adultos) + (diaria * criancas / 2);
            Console.WriteLine("O valor por dia da família será: " + valordia.ToString("C"));

            Console.WriteLine("Informe o número de dias da hospedagem: ");
            int dias = int.Parse(Console.ReadLine());

            double valortotal = valordia * dias;
            Console.WriteLine("O valor total da hospedagem é: " + valortotal.ToString("C"));

            Console.WriteLine("Informe o número de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());   

            double valorparcela = valortotal / parcelas;
            Console.WriteLine("O valor de cada parcela é: " + valorparcela.ToString("C"));

            Console.ReadKey();
        }
    }
}
