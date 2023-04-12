static void BarraCarregamento(string texto, int pontos, int tempo)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(texto);

    for (int i = 0; i < pontos; i++)
    {
        Console.Write($".");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
    Console.WriteLine($"");
}

BarraCarregamento("Testando",10,700);

BarraCarregamento("Carregando",15,1000);

BarraCarregamento("Finalizando",8,700);



