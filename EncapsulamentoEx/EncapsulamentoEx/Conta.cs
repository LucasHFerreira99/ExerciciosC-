using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoEx
{
    internal class Conta
    {
        
        public double Saldo { get; private set; }
        public string Nome { get; set;}
        public int Numero { get; private set;} 


        public Conta(string nome, int numero)
        {
            Nome = nome;
            Numero = numero;
            Saldo = 0;
        }

        public Conta(string nome, int numero, Double saldo) : this(nome, numero)  
        {
            //Saldo = saldo;
            Deposito(saldo);
        }
        
        public void Deposito (double valor)
        {
            Saldo += valor;
        } 

        public void Saque (double valor) {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Nome}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
