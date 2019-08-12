using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.Banco.Model
{
    abstract class Conta
    {
        //propriedades
        public int Agencia { get; set; }
        public DateTime DataAbertura { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; set; }

        //métodos abstratos
        public abstract decimal Depositar(decimal valor);

        public abstract decimal Retirar(decimal valor);
    }
}
