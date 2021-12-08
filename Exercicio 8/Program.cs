using System;

namespace Exercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Entre com o número da conta: ");
                int numeroDaConta = int.Parse(Console.ReadLine());

                Console.Write("Informe o titular da conta: ");
                string titular = Console.ReadLine();

                char opcao = 'S';

                do
                {
                    if(opcao != 'S')
                    {
                        Console.WriteLine(">Responda com S ou N");
                    }
                    Console.Write("Havera depósito inicial(s/n)? ");
                    opcao = char.Parse(Console.ReadLine());
                    opcao = Char.ToUpper(opcao);
                } while (opcao != 'N' && opcao != 'S');

                Conta conta = new Conta(numeroDaConta, titular);
                double deposito = 0;

                if (opcao == 'S')
                {
                    Console.Write("Entre com o valor do depósito inicial: ");
                    deposito = double.Parse(Console.ReadLine());

                    conta = new Conta(numeroDaConta, titular, deposito);

                    Console.WriteLine($"\nDados da Conta:\n{conta}");
                }
                else
                {
                    Console.WriteLine($"\n{conta}");
                }

                Console.Write("\nEnte um valor para depósito: ");
                deposito = double.Parse(Console.ReadLine());
                conta.AdicionarNoDeposito(deposito);
                Console.WriteLine($"{conta}");

                //Taxa de $5 a cada saque 
                Console.Write("\nEnte um valor para saque: ");
                deposito = double.Parse(Console.ReadLine());
                conta.RemoverNoDeposito(deposito);
                Console.WriteLine($"{conta}");

                Console.WriteLine("\nPressione qualquer tecla para finalizar");
                Console.ReadKey();
            }
            catch (Exception falha)
            {
                Console.WriteLine($">{falha.Message}");
                Console.ReadKey();
            } 
        }
    }
}
