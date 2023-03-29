// string name = "Marcelo";
// Console.WriteLine(name);

// // int idade = 19;

// const int idade =19;

// Console.WriteLine("A idade do " + name + " é " + idade + " anos");

// Operadores

// Atribuiçao =

// int x = 15;

// // Atribuidores aritmeticos 
// // soma
// Console.WriteLine(5 + 4);
// Console.WriteLine(5 + "4");
// Console.WriteLine(5 + x);


// // subtracao
// Console.WriteLine(x - 3);

// // multiplicacao

// Console.WriteLine(5*5);


// // divisao
// Console.WriteLine(10/10);


// // Modular 
// Console.WriteLine(5 % 2);

// Operadores de comparacao 

// // Igual a
// Console.WriteLine(5 == 7);


// // Maior ou igual a 
// Console.WriteLine(5 >= 4);


// // Menor ou igual a
// Console.WriteLine(4 <= 2);


// // Maior que 
// Console.WriteLine(150 > 95);


// // Menor que 
// Console.WriteLine(54 < 54);


// // Diferente de
// Console.WriteLine(5 != 6);


// Operadores logicos

// && : e true && true = true

// Console.WriteLine(5 == 5 && 8 == 8);
// Console.WriteLine(5 == 5 && 8 == 4);


// // || : ou  true || true = true / true || false = true
// Console.WriteLine(2 == 2 || 3 == 4);
// Console.WriteLine(2 == 1 || 5 == 3);
// Console.WriteLine((2 == 4 && 2 == 5) || 7 == 7);


// // ! : nao
// Console.WriteLine(!(2 == 2 || 3 == 3));



// Crie um programa para calcular um IMC de uma pessoa 

// Algoritmo
// entrada: nome, idade , peso, altura
// processamento: peso/altura*altura


// Entrada
string nome = "Marcelo";

int idade = 19;

float peso = 66;

float altura = 1.73f;

// Processamento
float imc = peso/(altura*altura);

// Saida 
Console.WriteLine("O IMC do " + nome + "é de : " + Math.Round(imc,2));
