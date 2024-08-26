/*-------------------------------------------------------------------
Questão 5: Cálculo de Distância Percorrida
* Contextualização:Um veículo no jogo percorre uma certa distância em um tempo determinado.
* Comando: Crie um programa que receba a velocidade do veículo, o tempo de viagem e dois
multiplicadores (um para condições climáticas e outro para estado do veículo), e calcule a
distância total percorrida
@Lista: 01 - Lógica de Programação
@Autor: Brenda kelly tavares 
@Data: 24/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
         double velocidade, tempo, multiplicadorClima, multiplicadorVeiculo;

        Console.Write("Digite a velocidade do veículo: ");
        double.TryParse(Console.ReadLine(), out velocidade);

        Console.Write("Digite o tempo de viagem: ");
        double.TryParse(Console.ReadLine(), out tempo);

        Console.Write("Digite o multiplicador das condições climáticas: ");
        double.TryParse(Console.ReadLine(), out multiplicadorClima);

        Console.Write("Digite o multiplicador do estado do veículo: ");
        double.TryParse(Console.ReadLine(), out multiplicadorVeiculo);
        
        double distanciaPercorrida = velocidade + tempo + multiplicadorClima * multiplicadorVeiculo;

        Console.WriteLine($"A distância total percorrida pelo veículo é: {distanciaPercorrida} km");
    }
}