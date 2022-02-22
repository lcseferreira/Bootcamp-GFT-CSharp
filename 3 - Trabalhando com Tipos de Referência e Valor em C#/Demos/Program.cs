using static System.Console;

partial class Program
{
    static void Main()
    {
        // Reference Type Pessoa
        Pessoa pessoa = new Pessoa(nome: "Lucas", idade: 24, documento: "456123123-99");

        WriteLine($"Nome da pessoa: {pessoa.Nome}");

        // Tipos por referência são alocados na heap, então o que é passado é a referência na memória
        MudarNomePessoa(pessoa, "Lucas Eduardo");

        WriteLine($"Nome da pessoa: {pessoa.Nome}");
    }
}