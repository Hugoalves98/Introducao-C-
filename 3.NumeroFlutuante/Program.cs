using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Variáveis Ponto Flutuante");
        double salario;
        salario = 3000.10;

        salario = 3000;
        Console.WriteLine(salario);

        /*int pagamento;
        pagamento = 5000.10; VAI DAR ERRO, double aceita inteiro, mas contrário nao
        Console.WriteLine(pagamento); */

        double idade;

        idade = 7.0 / 5; //Precisa ter .0 pra mostrar que tem casa decimal, senão consideraria inteiros e devolveria 1
        
        int valor = 12.5;             // não compila.

        int valor2 = 0.0;             // não compila.

        double teste = 125.50;        // compila

        int valor3 = teste;           // não compila.


        Console.WriteLine("Tecle qualquer tecla pra fechar");
        Console.ReadLine();
    }
}

