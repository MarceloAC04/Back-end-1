Console.WriteLine($"Digite uma letra");
char letra = char.Parse(Console.ReadLine());

if (letra == 'a' || letra =='A' || letra == 'E' || letra == 'e')
{
    Console.WriteLine($"{letra} é uma vogal");
}
else if (letra == 'i' || letra =='I' || letra == 'o' || letra == 'O')
{
    Console.WriteLine($"{letra} é uma vogal");
}
else if (letra == 'u' || letra =='U')
{
    Console.WriteLine($"{letra} é uma vogal");
}
else 
{
    Console.WriteLine($"{letra} é uma consoante");
}


