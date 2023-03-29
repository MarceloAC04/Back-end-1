﻿// Crie um programa para calcular um IMC de uma pessoa 

// Algoritmo
// entrada: nome, idade , peso, altura
// processamento: peso/altura*altura


// Entrada
Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.WriteLine(@$"
--------------------
|  Programa para   |
|  calcular IMC    |
--------------------
");
Console.ResetColor();

Console.WriteLine($"Digite o nome do paciente:");
string nome = Console.ReadLine();

Console.WriteLine($"Bem-Vindo! ao nosso sistema {nome} ;)");


Console.WriteLine($"Informe o peso do paciente");
float peso = float.Parse(Console.ReadLine());


// Exemplo
// Console.WriteLine($"Informe a altura do paciente");
// double altura = double.Parse(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"Informe a altura do paciente");
float altura = float.Parse(Console.ReadLine());

// // Processamento
float imc = (peso / (float)Math.Pow(altura,2));

// // Saida 
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"O paciente {nome} tem imc igual á : {imc}");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Obrigado por utilizar nosso sistema");
Console.ResetColor();

