int numeroAntigo = 0;
int numeroAtual = 1;
int novoNumero;

for (int i = 0; i < 14; i++)
{
    novoNumero = (numeroAtual + numeroAntigo);
    Console.WriteLine($"{novoNumero}");
    numeroAntigo = numeroAtual;
    numeroAtual = novoNumero;
}
