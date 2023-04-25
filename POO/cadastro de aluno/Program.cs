using System.Globalization;
using cadastro_de_aluno;

Aluno novoAluno = new Aluno();

string respostaBolsa;
string menu;
string sair;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Seja Bem-Vindo");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"Informe o nome do aluno ");
novoAluno.nome = Console.ReadLine();

Console.WriteLine($"Informe o curso do aluno");
novoAluno.curso = Console.ReadLine();

Console.WriteLine($"Informe a idade do aluno");
novoAluno.idade = Console.ReadLine();

Console.WriteLine($"Informe o rg do aluno");
novoAluno.rg = Console.ReadLine();


Console.WriteLine($"Informe a média final do aluno");
novoAluno.mediaFinal = int.Parse(Console.ReadLine());
while (novoAluno.mediaFinal < 0 || novoAluno.mediaFinal > 10)
{
    Console.WriteLine($"Informe corretamente a media final");
    novoAluno.mediaFinal = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Informe o valor da mensalidade do aluno");
novoAluno.mensalidade = int.Parse(Console.ReadLine());
while (novoAluno.mensalidade < 0)
{
    Console.WriteLine($"Informe corretamente o valor da  mensalidade");
    novoAluno.mensalidade = int.Parse(Console.ReadLine());
}
Console.ResetColor();

Console.WriteLine($"O aluno é bolsista? S/N");
respostaBolsa = Console.ReadLine().ToUpper();
novoAluno.bolsa = respostaBolsa == "S" ? true : false;

do
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($@"
    --------------------------
    |         MENU           |
    | 0 - Sair               |
    | 1 - Ver Media final    |
    | 2 - Ver Mensalidade    |
    --------------------------
    ");
    Console.ResetColor();
    Console.WriteLine($"Digite uma opção");
    menu = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.Green;
    switch (menu)
    {
        case "0":
            Console.WriteLine($"Até a proxima");
            break;
        case "1":
            novoAluno.VerMediaFinal();
            do
            {
                Console.WriteLine($"Digite 'ok' para sair");
                sair = Console.ReadLine().ToLower();
            } while (sair != "ok");
            break;
        case "2":
            if (novoAluno.bolsa)
            {
                Console.WriteLine($"O aluno possue desconto na mensalidade");
                Console.WriteLine($"A mensalidade do aluno com desconto é de {novoAluno.VerMensalidade().ToString("C", new CultureInfo("pt-BR"))}");
            }
            else
            {
                Console.WriteLine($"A mensalidade do aluno é {novoAluno.VerMensalidade().ToString("C", new CultureInfo("pt-BR"))}");
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
    Console.ResetColor();
}
while (menu != "0");