using System.Globalization;
using cadastro_de_aluno;

Aluno p1 = new Aluno();

string respostaBolsa;
string menu;

Console.WriteLine($"Seja Bem-Vindo");

Console.WriteLine($"Informe o seu nome");
p1.nome = Console.ReadLine();

Console.WriteLine($"Informe o seu curso");
p1.curso = Console.ReadLine();

Console.WriteLine($"Informe a sua idade");
p1.idade = int.Parse(Console.ReadLine());
while (p1.idade < 0)
{
    Console.WriteLine($"Informe corretamente sua idade");
    p1.idade = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Informe o seu rg");
p1.rg = Console.ReadLine();

Console.WriteLine($"Voce é bolsista? S/N");
respostaBolsa = Console.ReadLine().ToUpper();

Console.WriteLine($"Informe a sua média final");
p1.mediaFinal = int.Parse(Console.ReadLine());
while (p1.mediaFinal < 0)
{
    Console.WriteLine($"Informe corretamente sua media final");
    p1.mediaFinal = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Informe a sua mensalidade");
p1.mensalidade = int.Parse(Console.ReadLine());
while (p1.mensalidade < 0)
{
    Console.WriteLine($"Informe corretamente sua idade");
    p1.mensalidade = int.Parse(Console.ReadLine());
}

do
{
    Console.WriteLine($@"
    --------------------------
    |         MENU           |
    | 0 - Sair               |
    | 1 - Ver Media final    |
    | 2 - Ver Mensalidade    |
    --------------------------
    ");
    Console.WriteLine($"Digite uma opção");
    menu = Console.ReadLine();
    switch (menu)
    {
        case "0":
            Console.WriteLine($"Até a proxima");
            break;
        case "1":
            Console.WriteLine($"A sua média final é {p1.VerMediaFinal()}");
            string sair;
            do
            {
                Console.WriteLine($"Digite 'ok' para sair");
                sair = Console.ReadLine().ToLower();
            } while (sair != "ok");
            break;
        case "2":
            if (respostaBolsa == "S")
            {
                p1.bolsa = true;
                Console.WriteLine($"Você possue desconto na mensalidade");
                Console.WriteLine($"Sua mensalidade com desconto é {p1.VerMensalidade().ToString("C", new CultureInfo("pt-BR"))}");

            }
            else
            {
                Console.WriteLine($"Sua mensalidade é {p1.VerMensalidade().ToString("C", new CultureInfo("pt-BR"))}");
            }
            do
            {
                Console.WriteLine($"Digite 'ok' para sair");
                sair = Console.ReadLine().ToLower();
            } while (sair != "ok");
            break;
        default:
            Console.WriteLine($"Digite uma opção válida");
            break;
    }

}
while (menu != "0");

