float ladoA;
float ladoB;
float ladoC;

Console.WriteLine($"Informe o lado A do triangulo");
ladoA = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o lado B do triangulo");
ladoB= float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o lado C do triangulo");
ladoC = float.Parse(Console.ReadLine());

if ( ladoA == ladoB && ladoB == ladoC && ladoA == ladoC)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine($" Triângulo Equilátero");
    Console.ResetColor();   
}
else if ( ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Triângulo Isósceles");
    Console.ResetColor(); 
}
else 
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"Triângulo Escaleno");
     Console.ResetColor(); 
}
