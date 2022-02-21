using Revisao;

List<Aluno> alunos = new List<Aluno>();

string opcaoUsuario = GetOpcaoUsuario();

while (opcaoUsuario != "0")
{
    switch (opcaoUsuario)
    {
        case "1":
            Console.WriteLine("Informe o nome do aluno: ");
            Aluno aluno = new Aluno();
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Informe a nota do aluno: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
            {
                aluno.Nota = nota;
            }
            else
            {
                throw new ArgumentException("O valor da nota deve ser decimal.");
            }

            alunos.Add(aluno);

            break;
        case "2":
            foreach (var a in alunos)
            {
                Console.WriteLine(a.Nome);
            }

            break;
        case "3":
            var soma = 0.0M;

            foreach (var a in alunos)
            {
                soma += a.Nota;
            }

            var media = soma / alunos.Count;

            Console.WriteLine($"Média dos alunos: {media.ToString("F2")}");

            break;
        default:
            throw new ArgumentOutOfRangeException();
    }

    Console.WriteLine();
    opcaoUsuario = GetOpcaoUsuario();
}



static string GetOpcaoUsuario()
{

    Console.WriteLine("Informe a opção desejada: ");
    Console.WriteLine("1 - Inserir novo aluno");
    Console.WriteLine("2 - Listar alunos");
    Console.WriteLine("3 - Calcular média geral");
    Console.WriteLine("0 - Sair");
    Console.WriteLine();

    var opcaoUsuario = Console.ReadLine();
    return opcaoUsuario;
}