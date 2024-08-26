/*-------------------------------------------------------------------
 Questão 4: Somatório de Moedas
* Contextualização:No seu jogo, o jogador coleta moedas durante uma fase. A cada coleta, o total
de moedas aumenta.
* Comando: Desenvolva um programa que receba cinco valores de moedas coletadas e some-os,
exibindo o total de moedas coletadas ao final.
@Lista: 01 - Lógica de Programação
@Autor: Brenda kelly tavares 
@Data: 24/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
         int moeda01, moeda02, moeda03, moeda04, moeda05;

        Console.Write("Digite o número da primeira moeda coletada: ");
        int.TryParse(Console.ReadLine(), out moeda01);

        Console.Write("Digite o número da segunda moeda coletada: ");
        int.TryParse(Console.ReadLine(), out moeda02);

        Console.Write("Digite o número da terceira moeda coletada: ");
        int.TryParse(Console.ReadLine(), out moeda03);

        Console.Write("Digite o número da quarta moeda coletada: ");
        int.TryParse(Console.ReadLine(), out moeda04);

        Console.Write("Digite o número da quinta moeda coletada: ");
        int.TryParse(Console.ReadLine(), out moeda05);

        int totalMoedas = moeda01 + moeda02 + moeda03 + moeda04 + moeda05;

        Console.WriteLine($"O total de moedas coletadas é: {totalMoedas}");
    }
}