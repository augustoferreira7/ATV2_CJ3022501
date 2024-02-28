using System.Runtime.Serialization;

namespace ATV2_CJ3022501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, novo_salario;
            /*
            Console.WriteLine("Qual será o valor do funcionário ?");

            salario = float.Parse(Console.ReadLine());
            novo_salario = (salario / 100) * 25;
            salario += novo_salario;

            Console.WriteLine("o novo salário será de: {0}", salario);

            // Parte 2

            int n, n2, n3, total;
            Console.WriteLine();
            Console.WriteLine("Vamos para a parte 2:");
            Console.WriteLine("escolha um número");
            n = int.Parse(Console.ReadLine());
            n2 = n * 3 + 1;
            n3 = n * 2 - 1;
            total = n2 + n3;
            Console.WriteLine("A soma com o sucessor de seu triplo com o antecessor do seu dobro é igual a:\n{0}", total);

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

            // primeiro exercício da lista:
            */

            /*
            Console.WriteLine();
            float metros, centi, mili;
            Console.WriteLine("digite um valor em metros:");
            metros = float.Parse(Console.ReadLine());
            centi = metros * 100;
            mili = metros * 1000;
            Console.WriteLine("O número equivalente a centímetros em comparação ao metro escolhido é:{0}", centi);
            Console.WriteLine("O número equivalente a milimetros em comparação ao metro escolhido é:{0}", mili);


            //terceiro execício da lista
            Console.WriteLine();
            float alt, peso, imc, imc2;
            Console.WriteLine("Me informe a sua altura:");
            alt = float.Parse(Console.ReadLine());
            Console.WriteLine("Me informe seu peso");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (float)Math.Pow(alt, 2);
            
            Console.WriteLine("O IMC de seu corpo é:{0:F2}", imc);

            // quarto exercício da lista
            */
            /*
            Console.WriteLine();
            float not1, not2, not3,pes1,pes2,pes3,med1,med2,med3;
            Console.WriteLine("Digite três números:");
            not1 = float.Parse(Console.ReadLine());
            not2 = float.Parse(Console.ReadLine());
            not3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite os pesos refente a ordem dos números escolhidos");
            pes1 = float.Parse(Console.ReadLine());
            pes2 = float.Parse(Console.ReadLine());
            pes3 = float.Parse(Console.ReadLine());

            med1 = (not1 * pes1) + (not2 * pes2) + (not3 * pes3);
            med2 = pes1 + pes2 + pes3;
            med3 = (med1 / med2);
            Console.WriteLine("A média ponderada das notas escolhidas é de:{0}",med3);
            Console.WriteLine();

            // sétimo exercício da lista
            */
            float real, cota, resl;
            Console.WriteLine("Digite um valor em real e depois mencione a cotação do dolar em relação ao dolar:");
            real = float.Parse(Console.ReadLine());
            cota = float.Parse(Console.ReadLine());
            resl = (real / cota);
            Console.WriteLine("O valor em dolar é de:{0}", resl);

            // 11° execício da lista

            float n,cubo, quadrado;
            Console.WriteLine("digite um número");
            n = int.Parse(Console.ReadLine());
            cubo = (float)Math.Pow(n, 3);
            quadrado = (float)Math.Pow(n, 2);
            Console.WriteLine("O número ao quadrado é de:{0}, e o número ao cubo é de:{1}", quadrado,cubo);
        }
    }
}
