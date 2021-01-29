using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryContaCorrente.Model
{
    public class ContaCorrente
    {
        public ContaCorrente( int agencia, int numero, double saldo, string titular)
        {
            Titular = titular;
            Agencia = agencia;
            Numero = numero;
            Saldo = saldo;
        }

        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }
    }
}
