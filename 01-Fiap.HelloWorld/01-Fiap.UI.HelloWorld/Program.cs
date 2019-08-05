using _01_Fiap.UI.HelloWorld.Model;
using System;

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

            //Exibir o código do carro
            Console.WriteLine(carro.Codigo);

            Console.WriteLine("Hello World!");
        }
    }
}
