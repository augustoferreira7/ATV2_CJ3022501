using System.Runtime.Serialization;

namespace ATV2_CJ3022501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, novo_salario;
           
            Console.WriteLine("Qual será o valor do funcionário ?");
             
                salario = float.Parse(Console.ReadLine());
                novo_salario = (salario / 100) * 25;
                salario += novo_salario;
           
            Console.WriteLine("o novo salário será de: {0}", salario);

            // Parte 2

            int n, n2, n3, total;
            Console.WriteLine( );
            Console.WriteLine("Vamos para a parte 2:");
            Console.WriteLine("escolha um número");
            n = int.Parse(Console.ReadLine());
            n2 = n * 3 + 1;
            n3 = n * 2 - 1;
            total = n2 + n3;
            Console.WriteLine("A soma com o sucessor de seu triplo com o antecessor do seu dobro é igual a:\n{0}",total);

            // Parte 3
            Console.WriteLine();
            Console.WriteLine("Vamos para a parte 3");
            float valor = 1000, valor2, valor3;
            valor2 = (valor / 100) * 3.4f;
            valor -= valor2;
            valor2 = (valor / 100) * 2.8f;
            valor += valor2;
            valor2 = (valor / 100) * 14.0f;
            valor += valor2;
            valor2 = (valor / 100) * 8.5f;
            valor -= valor2;
            Console.WriteLine("O valor final é de: {0}", valor);

        }
    }
}
