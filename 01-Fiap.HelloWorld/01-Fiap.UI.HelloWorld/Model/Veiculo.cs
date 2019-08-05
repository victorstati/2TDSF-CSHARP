using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.Model
{
    class Veiculo
    {
        //Atributos - Fields
        private int _codigo;


        //Métodos - Gets/Sets
        public string Cor { get; set; }

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        
    }
}
