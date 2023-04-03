Console.WriteLine($"Digite uma letra");
char letra = char.Parse(Console.ReadLine().ToLower());

if (letra == 'a' || letra =='e' || letra == 'i' || letra == 'o'  || letra == 'u' )
{
    Console.WriteLine($"{letra} é uma vogal");
}
else 
{
    Console.WriteLine($"{letra} é uma consoante");
}


