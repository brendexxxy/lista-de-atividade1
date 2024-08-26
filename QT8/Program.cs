/*-------------------------------------------------------------------
Questão 8: Cálculo de Pontos de Habilidade
* Contextualização: Ao subir de nível, um jogador recebe pontos de habilidade que podem ser
distribuídos entre força, agilidade, inteligência e dois atributos adicionais.
* Comando: Desenvolva um programa que receba a quantidade de pontos de habilidade
atribuídos a cada uma das cinco características e calcule o total de pontos distribuídos
@Lista: 01 - Lógica de Programação
@Autor: Brenda kelly tavares 
@Data: 24/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
        int pontosForca, pontosAgili, pontosInteligen, pontosAtributo1, pontosAtributo2;

        Console.Write("Digite o número de pontos atribuídos à Força: ");
        int.TryParse(Console.ReadLine(), out pontosForca);

        Console.Write("Digite o número de pontos atribuídos à Agilidade: ");
        int.TryParse(Console.ReadLine(), out pontosAgili);

        Console.Write("Digite o número de pontos atribuídos à Inteligência: ");
        int.TryParse(Console.ReadLine(), out pontosInteligen);

        Console.Write("Digite o número de pontos atribuídos ao Atributo Adicional 1: ");
        int.TryParse(Console.ReadLine(), out pontosAtributo1);

        Console.Write("Digite o número de pontos atribuídos ao Atributo Adicional 2: ");
        int.TryParse(Console.ReadLine(), out pontosAtributo2);

       
        int totalPontosDistribuidos = pontosForca + pontosAgili + pontosInteligen + pontosAtributo1 + pontosAtributo2;

    
        Console.WriteLine($"O total de pontos distribuídos é: {totalPontosDistribuidos}");
    }
}