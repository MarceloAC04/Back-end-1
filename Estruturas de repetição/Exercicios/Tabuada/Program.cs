Console.WriteLine($"Digite um número inteiro");
int x = int.Parse(Console.ReadLine());

int i = 1;

Console.WriteLine($"A tabuada desse número é");

do 
{
   Console.WriteLine($"{x * i}");
   i++;
}
while (i <= 10);

