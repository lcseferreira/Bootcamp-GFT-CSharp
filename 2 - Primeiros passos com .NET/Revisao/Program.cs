Console.WriteLine("Informe a opção desejada: ");
Console.WriteLine("1 - Inserir novo aluno");
Console.WriteLine("2 - Listar alunos");
Console.WriteLine("3 - Calcular média geral");
Console.WriteLine("0 - Sair");
Console.WriteLine();

var opcaoUsuario = Console.ReadLine();

while (opcaoUsuario != "0")
{
    switch (opcaoUsuario)
    {
        case "1":
            // TODO: Adicionar aluno
            break;
        case "2":
            // TODO: Listar alunos
            break;
        case "3":
            // TODO: Calcular média geral
            break;
        default:
            throw new ArgumentOutOfRangeException();
    }

    Console.WriteLine("Informe a opção desejada: ");
    Console.WriteLine("1 - Inserir novo aluno");
    Console.WriteLine("2 - Listar alunos");
    Console.WriteLine("3 - Calcular média geral");
    Console.WriteLine("0 - Sair");
    Console.WriteLine();

    opcaoUsuario = Console.ReadLine();
}