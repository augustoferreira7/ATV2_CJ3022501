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
            

            
            Console.WriteLine();
            float metros, centi, mili;
            Console.WriteLine("digite um valor em metros:");
            metros = float.Parse(Console.ReadLine());
            centi = metros * 100;
            mili = metros * 1000;
            Console.WriteLine("O número equivalente a centímetros em comparação ao metro escolhido é:{0}", centi);
            Console.WriteLine("O número equivalente a milimetros em comparação ao metro escolhido é:{0}", mili);
            
            
            // segundo exercício da lista
            
            float ceu, fah;

            Console.WriteLine();
            Console.WriteLine("Qual o valor em Fahrenheit que deseja aplicar ?");
            fah = float.Parse(Console.ReadLine());
            ceu = (fah - 32.0f) * (5.0f / 9.0f);
            Console.WriteLine("O valor de Fahrenheit em graus celsius é: {0:f2}", ceu);
            Console.WriteLine();


            int grau, fa;
            Console.WriteLine();
            Console.WriteLine("Qual o valor em Fahrenheit que deseja aplicar ?");
            fa = int.Parse(Console.ReadLine());
            grau = (fa - 32) * (5 / 9);
            Console.WriteLine("O valor de Fahrenheit em graus celsius é: {0:f2}", grau);

            
            
            
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
            

            // quinto exercício da lista

            float velo, distancia, tempo, tempo2;
            Console.WriteLine("Hoje iremos descobrir a velocidade de um objeto, precisando apenas do tempo percorrido e uma distância fixa:");
            Console.WriteLine("Digite o tempo gasto em minutos:");
            tempo = float.Parse(Console.ReadLine());
            tempo2 = tempo ;
            Console.WriteLine("Digite a distância percorrida em metros:");
            distancia = float.Parse(Console.ReadLine());
            velo = distancia/ tempo2;
            Console.WriteLine("A velocidade do objeto em metros por segundo é de: {0}", velo);



            // sétimo exercício da lista

            
            float real, cota, resl;
            Console.WriteLine("Digite um valor em real e depois mencione a cotação do dolar em relação ao dolar:");
            real = float.Parse(Console.ReadLine());
            cota = float.Parse(Console.ReadLine());
            resl = (real / cota);
            Console.WriteLine("O valor em dolar é de:{0}", resl);
            

            Console.WriteLine("Digite um número inteiro de 4 dígitos:");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 1000 || numero > 9999)
            {
                Console.WriteLine("Número inválido. Digite um número de 4 dígitos.");
                return;
            }

            Console.WriteLine("Os dígitos do número são:");

            int digitoMilhar = numero / 1000;
            int digitoCentena = (numero % 1000) / 100;
            int digitoDezena = (numero % 100) / 10;
            int digitoUnidade = numero % 10;

            Console.WriteLine(digitoMilhar);
            Console.WriteLine(digitoCentena);
            Console.WriteLine(digitoDezena);
            Console.WriteLine(digitoUnidade);


            // 11° execício da lista

            float cubo, quadrado;

            Console.WriteLine("digite um número");
            n = int.Parse(Console.ReadLine());
            cubo = (float)Math.Pow(n, 3);
            quadrado = (float)Math.Pow(n, 2);
            Console.WriteLine("O número ao quadrado é de:{0}, e o número ao cubo é de:{1}", quadrado,cubo);
            Console.WriteLine(  );

            //12° exercício da lista
            
            
            Console.WriteLine();
            float altura, pesoIdeal;
            char sexo;

            Console.WriteLine("Digite a altura em metros:");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o sexo (M para masculino, F para feminino):");
            sexo = char.Parse(Console.ReadLine());


            if (sexo == 'M' || sexo == 'm')
            {
                pesoIdeal = (72.7f * altura) - 58;
                Console.WriteLine($"O peso ideal para um homem com altura {altura}m é {pesoIdeal}kg.");
            }
            else if (sexo == 'F' || sexo == 'f')
            {
                pesoIdeal = (62.1f * altura) - 44.7f;
                Console.WriteLine($"O peso ideal para uma mulher com altura {altura}m é {pesoIdeal:F2}kg.");
            }
            else
            {
                Console.WriteLine("Sexo inválido. Por favor, digite M para masculino ou F para feminino.");
            }



            Console.WriteLine();
            Console.WriteLine("O Github é uma “rede social dev” em que é possível armazenar e compartilhar projetos de desenvolvimento de software.\r\n\r\nO Git é um sistema de controle de versão de arquivos; em outras palavras, é responsável por guardar o histórico de alterações sempre que alguém modificar algum arquivo que está sendo monitorado por ele.\r\n\r\nDesta maneira, o Git e o GitHub são pilares fundamentais que auxiliam as equipes de desenvolvimento a controlar o versionamento de código, rastrear mudanças, colaborar de forma eficiente e garantir que o trabalho em equipe flua sem problemas.");
            Console.WriteLine("epositórios (Repositories): Locais onde seu código é armazenado, gerenciado e compartilhado. Cada projeto tem seu repositório.");
            Console.WriteLine("Commits: São as alterações individuais feitas no código. Cada commit tem uma mensagem associada descrevendo as mudanças");
            Console.WriteLine("Branches (Ramos): Permitem que você trabalhe em diferentes versões do seu projeto simultaneamente. Isso é útil para o desenvolvimento de recursos sem interferir no código principal");
            Console.WriteLine("Pull Requests (Solicitações de Pull): Permitem que você solicite a integração de suas alterações de um branch para outro. Facilitam a revisão de código por outros colaboradores.");
            Console.WriteLine("Issues (Questões): São usadas para rastrear tarefas, melhorias, bugs ou discussões relacionadas ao projeto.");
            Console.WriteLine("Wiki: Um espaço onde você pode criar e gerenciar documentação para o seu projeto. É útil para fornecer informações adicionais sobre o código e seu funcionamento.");
            Console.WriteLine("Projetos: Oferecem uma maneira de organizar e gerenciar tarefas, permitindo a criação de um quadro de kanban para visualizar o progresso do projeto");
            Console.WriteLine("Actions (Ações): Permite automatizar tarefas com base em eventos, como a execução de testes ou a implantação automática do código.");
            Console.WriteLine("Seguidores e Estrelas: Você pode seguir outros usuários para receber atualizações de suas atividades. Além disso, pode marcar repositórios com estrelas para salvá-los e mostrar apoio.");
            Console.WriteLine("Gists: Permitem compartilhar pequenos trechos de código ou notas com outras pessoas, mesmo que não estejam vinculados a um projeto específico.");



        }
       
}
}
