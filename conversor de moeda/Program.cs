using System;

class ConversorDeMoeda
{
    static void Main(string[] args)
    {
        double cotacao, dolares, reais;

        Console.Write("Digite a cotação do dólar: ");
        cotacao = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor em dólares: ");
        dolares = double.Parse(Console.ReadLine());

        reais = cotacao * dolares;

        Console.WriteLine("O valor em reais é: " + reais.ToString("F2"));
    }
}
