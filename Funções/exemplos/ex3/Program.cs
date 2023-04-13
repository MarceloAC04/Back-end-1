using System.Globalization;

static void ImpostoRenda(float renda)
{
    if (renda <= 1500)
    {
        Console.WriteLine($"Isento de imposto");
    }
    else if (renda >= 1501 && renda <=3500)
    {
        Console.WriteLine($"O valor de imposto referente a sua renda será de {Math.Round(renda * 0.20,2).ToString("C", new CultureInfo("pt-BR"))}");
    }
    else if (renda >= 3501 && renda <=6000)
    {
        Console.WriteLine($"O valor de imposto referente a sua renda será de {Math.Round(renda * 0.25,2).ToString("C", new CultureInfo("pt-BR"))}");
    }
    else 
    {
        Console.WriteLine($"O valor de imposto referente a sua renda será de {Math.Round(renda * 0.35,2).ToString("C", new CultureInfo("pt-BR"))}");
    }
    
}

Console.WriteLine($"Qual é o valor de sua renda ?");
float renda = float.Parse(Console.ReadLine());
ImpostoRenda(renda);


