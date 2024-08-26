/*-------------------------------------------------------------------
Questão 3: Cálculo de Vida Restante
* Contextualização: Durante um combate, o jogador recebe dano e a vida do personagem
diminui.
* Comando: Crie um programa que receba o valor da vida inicial, o dano recebido, o bônus de
regeneração, do atacado, e dois modificadores, do atacante, (um para equipamentos e outro
para habilidades), e calcule a vida restante.
@Lista: 01 - Lógica de Programação
@Autor: Brenda kelly tavares 
@Data: 24/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {

        int vidaInicial, danoRecebido, bonusRegeneracao;
        double modificadorEquipamentos, modificadorHabilidades;

        Console.Write("Digite o valor da vida inicial: ");
        int.TryParse(Console.ReadLine(), out vidaInicial);

        Console.Write("Digite os danos recebido: ");
        int.TryParse(Console.ReadLine(), out danoRecebido);

        Console.Write("Digite o bônus de regeneração: ");
        int.TryParse(Console.ReadLine(), out bonusRegeneracao);

        Console.Write("Digite o modificador de equipamentos: ");
        double.TryParse(Console.ReadLine(), out modificadorEquipamentos);

        Console.Write("Digite o modificador de habilidades: ");
        double.TryParse(Console.ReadLine(), out modificadorHabilidades);


        double danoTotal = danoRecebido * modificadorEquipamentos * modificadorHabilidades;

        double vidaRestante = vidaInicial - danoTotal + bonusRegeneracao;

        Console.WriteLine($"A vida restante do personagem é: {vidaRestante}");
    }
}
