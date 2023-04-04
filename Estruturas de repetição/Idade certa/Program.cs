bool idadeCerta = false;

while (idadeCerta == false)
{
    Console.WriteLine($"Qual a idade do pericles ?");
    int idade = int.Parse(Console.ReadLine());

    if (idade == 53)
    {
     idadeCerta = true;
    }
    
}