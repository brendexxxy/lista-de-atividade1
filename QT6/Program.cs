/*-------------------------------------------------------------------
Questão 6:Conversão de Moeda do Jogo
* Contextualização: O jogo possui uma loja onde os jogadores podem trocar moedas de ouro por
cristais.
* Comando: Desenvolva um programa que receba o valor de moedas de ouro, o valor da taxa de
conversão (1 cristal = X moedas de ouro), e dois bônus de conversão (um baseado em eventos
e outro em habilidades), e calcule o número de cristais que o jogador pode obter.
@Lista: 01 - Lógica de Programação
@Autor: Brenda kelly tavares 
@Data: 24/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
        double moedasOuro, taxaConversao, bonusEvento, bonusHabilidades;

        Console.Write("Digite o valor das moedas de ouro: ");
        double.TryParse(Console.ReadLine(), out moedasOuro);

        
        Console.Write("Digite o valor da taxa de conversão: ");
        double.TryParse(Console.ReadLine(), out taxaConversao);

        Console.Write("Digite o bônus de conversão de eventos: ");
        double.TryParse(Console.ReadLine(), out bonusEvento);

        Console.Write("Digite o bônus de conversão de habilidades: ");
        double.TryParse(Console.ReadLine(), out bonusHabilidades);

        double fatorConversao =  + bonusEvento + bonusHabilidades;

     
        double cristaisObtidos =  (moedasOuro / taxaConversao) * fatorConversao;
      
        Console.WriteLine($"O número de cristais que o jogador pode obter é: {cristaisObtidos}");
    }
}