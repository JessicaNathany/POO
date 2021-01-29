using ClassLibraryContaCorrente.Model;
using ClassLibraryContaCorrente.Service;
using System;

namespace PresentationContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrenteService contaService = new ContaCorrenteService();
            ContaCorrente origem = new ContaCorrente(1, 889, 500, "Ludmyla");
            ContaCorrente destino = new ContaCorrente(1, 152, 200, "Michel");

            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();

            Console.WriteLine(" ..:: Selecione uma opção ::..");
            Console.WriteLine();
            Console.WriteLine("1 - Sacar");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Transferir");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {

                case '1':
                    Console.WriteLine("Digite o valor que quer sacar: " + "\n");
                    var valorsacado = double.Parse(Console.ReadLine());
                    contaService.OperacaoSaque(valorsacado, origem.Saldo);
                    break;

                case '2':
                    Console.WriteLine("Digite o valor que quer depositar: " + "\n");
                    var valordepos = double.Parse(Console.ReadLine());
                    contaService.OperacaoDeposito(valordepos, origem.Saldo);
                    break;

                case '3':
                    Console.WriteLine("Digite a valor para trasferencia: " + "\n");
                    var valortranf = double.Parse(Console.ReadLine());
                    contaService.OperacaoTransferencia(valortranf, destino, origem);
                    break;

            }

            }
    }
}
