using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.Model
{
    abstract class Veiculo
    {
        //Atributos - Fields
        private int _codigo;

        //Métodos
        public abstract void Ligar();

        //virtual permite a sobrescrita
        public virtual void Andar()
        {
            Console.WriteLine("Veículo em movimento");
        }

        //Métodos - Gets/Sets
        public string Cor { get; set; }

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        //Construtor - ctor tab tab
        public Veiculo(string cor)
        {
            this.Cor = cor;
        }

        public Veiculo()
        {

        }
        
    }
}
