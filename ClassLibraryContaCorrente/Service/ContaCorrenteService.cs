using ClassLibraryContaCorrente.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryContaCorrente.Service
{
    public class ContaCorrenteService
    {
        
        public void OperacaoSaque(double valor, double saldo)
        {
            Sacar(valor, saldo);
        }

        public void OperacaoDeposito(double valor, double saldo)
        {
            Depositar(valor, saldo);
        }

        public void OperacaoTransferencia(double valorTranferencia, ContaCorrente destino, ContaCorrente origem)
        {
           
            Transferir(valorTranferencia, destino, origem);
        }

        private double Sacar(double valor, double saldo)
        {
            if (saldo < valor)
            {
                Console.WriteLine($"Não foi possível concluir a transação. Seu saldo é inferior ao valor do saque!");
            }
            else
            {saldo -= valor;
                return saldo;
            }

            return saldo;
        }

        private double Depositar(double valor, double saldo)
        {
            saldo += valor;
            
            return saldo;
        }

        private bool Transferir(double valor,  ContaCorrente contaDestino, ContaCorrente contaCorrenteOrigem)
        {
         
            if (contaCorrenteOrigem.Saldo < valor)
            {
                Console.WriteLine($"Não foi possível concluir a transação. Seu saldo é inferior ao valor que deseja transferir!");
                return false;    
            }
            else
            {
                contaCorrenteOrigem.Saldo -= valor;
                contaDestino.Saldo = Depositar(valor, contaDestino.Saldo);
                Console.WriteLine($"Operação realizada com sucesso!");

                return true;
            }

            
            
        }

       
    }
}
