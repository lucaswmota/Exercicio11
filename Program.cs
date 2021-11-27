using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a cotação do Dolar: ");
            double cotacaoDolar = double.Parse(Console.ReadLine());

            Console.Write("Informe a cotação do Euro: ");
            double cotacaoEuro = double.Parse(Console.ReadLine());

            Console.Write("Informe a cotaçao do Ouro: ");
            double cotacaoOuro = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor a ser investido: ");
            double valorInvestido = double.Parse(Console.ReadLine());

            double investDolar = valorInvestido;
            double investEuro = valorInvestido;
            double investOuro = valorInvestido;

            double valorDolar = investDolar / cotacaoDolar;
            double valorEuro = investEuro / cotacaoEuro;
            double valorOuro = investOuro / cotacaoOuro;

            Console.WriteLine("\nValor em Dólar: $"+ valorDolar);
            Console.WriteLine("\nValor em Euro: $"+ valorEuro);
            Console.WriteLine("\nValor em Ouro: $"+ valorOuro);

            Console.Write("\n\n Pressione qualquer tecla para encerrar");
            Console.ReadKey();
        }
    }
}
