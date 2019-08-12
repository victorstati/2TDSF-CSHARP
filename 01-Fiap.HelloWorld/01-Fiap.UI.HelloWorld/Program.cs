using _01_Fiap.UI.HelloWorld.Model;
using System;
using System.Collections.Generic;

namespace _01_Fiap.UI.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um carro
            Carro carro = new Carro();

            //Atribuir o código do carro
            carro.Codigo = 1;
            carro.Tipo = TipoCarro.Hatch;


            //Exibir o código do carro
            Console.WriteLine(carro.Codigo);

            Console.WriteLine("Hello World!");

         

            //Iniciar um carro
            Carro carro2 = new Carro()
            {
                Portas = 4,
                Valor = 10000
            };

            
        }
    }
}
