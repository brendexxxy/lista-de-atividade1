/*-------------------------------------------------------------------
Atividade 9: Comparação de Poder de Ataque
* Contextualização: Em um jogo de luta, cada personagem tem um valor de ataque baseado em
sua força, arma e bônus de habilidades. O total de ataque é afetado por modificadores críticos
e pelo tipo da arma.
* Crie um programa que receba o valor da força do personagem, o poder da arma, o bônus de
Comando: habilidades, um modificador de crítico, e um modificador para o tipo da arma. O
programa deve calcular o total de ataque do personagem
@Lista: 01 - Lógica de Programação
@Autor: Brenda kelly tavares 
@Data: 24/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
         double forcaPersonagem, poderArma, bonusHabili, modificadorCritico, modificadorArma;

        Console.Write("Digite o numero da força do personagem: ");
        double.TryParse(Console.ReadLine(), out forcaPersonagem);
        Console.Write("Digite o poder da arma: ");
        double.TryParse(Console.ReadLine(), out poderArma);

        Console.Write("Digite o bônus de habilidades: ");
        double.TryParse(Console.ReadLine(), out bonusHabili);

        Console.Write("Digite o modificador de crítico: ");
        double.TryParse(Console.ReadLine(), out modificadorCritico);

        Console.Write("Digite o modificador do tipo da arma: ");
        double.TryParse(Console.ReadLine(), out modificadorArma);

        double totalAtaque = (forcaPersonagem + poderArma + bonusHabili) * modificadorCritico * modificadorArma;


        Console.WriteLine($"O total de ataque do personagem é: {totalAtaque}");
    }
}