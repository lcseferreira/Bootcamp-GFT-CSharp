using static System.Console;

partial class Program
{
    static void MudarNomePessoa(Pessoa pessoa, string nome)
    {
        pessoa.Nome = nome;
    }

    static void DemoReferencia()
    {
        // Reference Type Pessoa
        Pessoa pessoa1 = new Pessoa(nome: "Lucas", idade: 24, documento: "456123123-99");

        WriteLine($"Nome da pessoa: {pessoa1.Nome}");

        // Tipos por referência são alocados na heap, então o que é passado é a referência na memória
        MudarNomePessoa(pessoa1, "Lucas Eduardo");

        var pessoa2 = pessoa1;

        WriteLine($@"
        Nome da pessoa1: {pessoa1.Nome}
        Nome da pessoa2: {pessoa2.Nome}
        ");

        // O método Clone() usa o operador new, ou seja, aloca um novo espaço para o objeto na memória
        var pessoa3 = pessoa1.Clone();
        pessoa3.Nome = "Eduardo Ferreira";

        WriteLine($@"
        Nome da pessoa1: {pessoa1.Nome}
        Nome da pessoa2: {pessoa2.Nome}
        Nome da pessoa3: {pessoa3.Nome}
        ");
    }
}