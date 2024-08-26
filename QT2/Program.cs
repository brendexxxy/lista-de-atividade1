/*-------------------------------------------------------------------
Questão 2: Pontuação Final
* Contextualização: No final de uma missão em um jogo, a pontuação do jogador é calculada com
base nos inimigos derrotados e pontos adicionais.
* Comando: Desenvolva um programa que receba o número de inimigos derrotados, a pontuação
por inimigo, bônus por missão, e dois multiplicadores (um para tipo de inimigo e outro para
dificuldade), e então calcule e exiba a pontuação final.
@Lista: 01 - Lógica de Programação
@Autor: Brenda kelly tavares 
@Data: 24/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
        int inimigosDerrotados;
        int pontuacaoPorInimigo;
        int bonusPorMissao;
        double multiplicadorTipoInimigo;
        double multiplicadorDificuldade;

        Console.Write("Digite o número de inimigos derrotados: ");
        int.TryParse(Console.ReadLine(), out inimigosDerrotados);

        Console.Write("Digite a pontuação por inimigo: ");
        int.TryParse(Console.ReadLine(), out pontuacaoPorInimigo);

        Console.Write("Digite o bônus da missão: ");
        int.TryParse(Console.ReadLine(), out bonusPorMissao);

        Console.Write("Digite o multiplicador para o tipo de inimigo: ");
        double.TryParse(Console.ReadLine(), out multiplicadorTipoInimigo);

        Console.Write("Digite o multiplicador para a dificuldade: ");
        double.TryParse(Console.ReadLine(), out multiplicadorDificuldade);

        int pontuacaoBase = inimigosDerrotados * pontuacaoPorInimigo;
        double pontuacaoFinal = (pontuacaoBase + bonusPorMissao) * multiplicadorTipoInimigo * multiplicadorDificuldade;

        Console.WriteLine($"A pontuação final é: {pontuacaoFinal}");
    }
}
