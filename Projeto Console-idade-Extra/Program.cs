Console.WriteLine($"Informe seu ano de nascimento");
int ano = int.Parse(Console.ReadLine());

var data = DateTime.Now;

int dataAtual = data.Year;

int idade = (dataAtual - ano);

int semanas = (idade * 52);

Console.WriteLine($"Sua idade corresponde á {idade} ano(s) e aproximadamente {semanas} semanas");

