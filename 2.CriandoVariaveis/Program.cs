using System;
class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 2 - Criando Variáveis");
            int idade;
            idade = 27;
            Console.WriteLine("Minha idade daqui a três anos será " + idade);
            idade = 27 - 5 * 2;
            Console.WriteLine(idade);
            idade = (5 - 3) * 2;
            Console.Write(idade);
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
        }
    }