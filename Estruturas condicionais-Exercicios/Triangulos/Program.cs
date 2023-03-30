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
    Console.WriteLine($" Triângulo Equilátero");   
}
else if ( ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
{
    Console.WriteLine($"Triângulo Isósceles");
}
else 
{
    Console.WriteLine($"Triângulo Escaleno");
}
