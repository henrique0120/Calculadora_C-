using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;

bool continuar = true;

while (continuar)
{

    Console.WriteLine("1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n0 - Sair");
    int calc = int.Parse(Console.ReadLine());


    switch (calc)
    {
        case 1:
            Console.Write("Digite o primeiro valor: ");
            string input1 = Console.ReadLine();

            Console.Write("Digite o segundo valor: ");
            string input2 = Console.ReadLine();

            if (float.TryParse(input1, out float n1) && float.TryParse(input2, out float n2))
            {
                float sum = n1 + n2;
                Console.WriteLine($"A soma entre {n1} e {n2} é {sum}.");
                break;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira números válidos para ambos os valores.");
                break;
            }


        case 2:
            Console.Write("Digite o primeiro valor: ");
            string input3 = Console.ReadLine();

            Console.Write("Digite o segundo valor: ");
            string input4 = Console.ReadLine();

            if (float.TryParse(input3, out float n3) && float.TryParse(input4, out float n4))
            {
                float sub = n3 - n4;
                Console.WriteLine($"A subtração entre {n3} e {n4} é {sub}.");
                break;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira números válidos para ambos os valores.");
                break;
            }

        case 3:
            Console.Write("Digite o primeiro valor: ");
            string input5 = Console.ReadLine();

            Console.Write("Digite o segundo valor: ");
            string input6 = Console.ReadLine();

            if (float.TryParse(input5, out float n5) && float.TryParse(input6, out float n6))
            {
                float mult = n5 * n6;
                Console.WriteLine($"A multiplicação entre {n5} e {n6} é {mult}.");
                break;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira números válidos para ambos os valores.");
                break;
            }

        case 4:
            Console.Write("Digite o primeiro valor: ");
            string input7 = Console.ReadLine();

            Console.Write("Digite o segundo valor: ");
            string input8 = Console.ReadLine();

            if (float.TryParse(input7, out float n7) && float.TryParse(input8, out float n8))
            {   
                if(n7 == 0 || n8 == 0)
                {
                    Console.WriteLine("Não é possível fazer uma divisão por zero.");
                    break;
                }
                else
                {
                    float div = n7 / n8;
                    Console.WriteLine($"A divisão entre {n7} e {n8} é {div}.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira números válidos para ambos os valores.");
                break;
            }

        case 0:
            continuar = false;
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
    Console.ReadLine();
    Console.Clear();

}