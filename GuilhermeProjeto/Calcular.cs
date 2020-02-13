using System;
using System.Collections.Generic;
using System.Text;

namespace GuilhermeProjeto
{
    public class Calcular
    {

        static void Main(string[] args)
        {

            double valorInicial = 0;
            int qtdParcelas = 0;
            double calcularParcela = 0;
            double parcelas = 0;

            Console.WriteLine("Informe o Valor das Parcelas ");
            parcelas = Double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Quantidade das Parcelas? ");
            qtdParcelas = int.Parse(Console.ReadLine());


            Console.WriteLine("Informe o Valor Inicial ?");
            valorInicial = Double.Parse(Console.ReadLine());


            if (parcelas > 5)
            {
                calcularParcela = parcelas * (0.01) + parcelas;
                             
            }

            Console.WriteLine("O Valor das Parcelas: " + (calcularParcela));
            Console.ReadKey();

        }
    }
}
    
        

        

            
   