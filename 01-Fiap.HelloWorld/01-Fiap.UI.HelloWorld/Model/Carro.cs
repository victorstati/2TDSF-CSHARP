using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.Model
{
    class Carro : Veiculo, IAutomatico
    {
        //Propriedades (gtes e sets)
        public int Portas { get; set; }
        public decimal Valor { get; set; }
        public TipoCarro Tipo { get; set; }

        //Construtor
        public Carro(string cor) : base(cor)
        {
            
        }

        public Carro()
        {

        }

        public override void Ligar()
        {
            Console.WriteLine("Carro ligado");
        }

        public override void Andar()
        {
            //base.Andar() - chama método do pai
            Console.WriteLine("Carro andando");
        }

        public void TrocarMarcha()
        {
            Console.WriteLine("Trocando de marcha");
        }
    }
}
