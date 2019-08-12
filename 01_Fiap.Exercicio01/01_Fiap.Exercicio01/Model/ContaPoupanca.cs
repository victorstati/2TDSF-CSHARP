using _01_Fiap.Exercicio01.Exception;
using _01_Fiap.Exercicio01.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        //Atributo
        private readonly decimal _rendimento;

        //Propriedade
        public decimal Taxa { get; set; }

        //Construtor
        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;
        }


        public override decimal Depositar(decimal valor)
        {
            Saldo += valor;
            return Saldo;
        }

        public override decimal Retirar(decimal valor)
        {
            if (Saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo -= valor + Taxa;
            return Saldo;
        }

        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }

    }
}
