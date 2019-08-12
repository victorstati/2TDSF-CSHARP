using _01_Fiap.Exercicio01.Exception;
using _01_Fiap.Exercicio01.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.Banco.Model
{
    //sealed -> classe não pode ser herdada
    sealed class ContaCorrente : Conta
    {
        //propriedade
        public TipoConta Tipo { get; set; }


        //metodos
        public override decimal Depositar(decimal valor)
        {
            Saldo += valor;
            return Saldo;
        }

        public override decimal Retirar(decimal valor)
        {
            if (Saldo < valor && Tipo == TipoConta.Comum)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo -= valor;
            return Saldo;

        }
    }
}
