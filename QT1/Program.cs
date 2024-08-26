/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
* Contextualização: Em um jogo de RPG, o jogador precisa inserir
as informações básicas do personagem antes de começar a aventura.
* Comando: Crie um programa que receba o

@Lista: 01 - Lógica de Programação
@Autor: Brenda kelly Tavares de lima
@Data: 19/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{

    static void Main()
    {

        int idade, nivel;
        string nome, raca, classe;
        Console.WriteLine("digite o nome do jogador: ");
         nome = Console.ReadLine();

        Console.WriteLine("digite a idade do jogador: ");
        int.TryParse(Console.ReadLine(), out idade);

        Console.WriteLine("digite a raça do jogador: ");
        raca = Console.ReadLine();

        Console.WriteLine("digite a classe do jogador: ");
        classe = Console.ReadLine();

        Console.WriteLine("digite a nível do jogador: ");
        int.TryParse(Console.ReadLine(), out nivel);

        Console.WriteLine("Nome:" + nome);
        Console.WriteLine("idade:" + idade);
        Console.WriteLine("raça:" + raca);
        Console.WriteLine("classe:" + classe);
        Console.WriteLine("Nível:" + nivel);
        
    }
}
