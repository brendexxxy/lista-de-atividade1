/*-------------------------------------------------------------------
Questão 10: Atualização de Pontos de Vida
* Contextualização: Em um jogo de estratégia, um personagem pode ganhar pontos de vida a
cada nível alcançado.
* Comando: Desenvolva um programa que receba os pontos de vida iniciais e o aumento de vida
por nível, e calcule a quantidade de pontos de vida após alcançar um novo nível
@Lista: 01 - Lógica de Programação
@Autor: Brenda kelly tavares 
@Data: 24/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
        
        int pontosVidaIniciais, aumentoPorNivel, niveisAlcancados;

        Console.Write("Digite os pontos de vida no inicio: ");
        int.TryParse(Console.ReadLine(), out pontosVidaIniciais);

        Console.Write("Digite o aumento de vida por nível: ");
        int.TryParse(Console.ReadLine(), out aumentoPorNivel);

        Console.Write("Digite o número de níveis alcançados: ");
        int.TryParse(Console.ReadLine(), out niveisAlcancados);

        int pontosVidaFinais = pontosVidaIniciais + (aumentoPorNivel * niveisAlcancados);

        Console.WriteLine($"A quantidade de pontos de vida após alcançar {niveisAlcancados} níveis é: {pontosVidaFinais}");
    }
}