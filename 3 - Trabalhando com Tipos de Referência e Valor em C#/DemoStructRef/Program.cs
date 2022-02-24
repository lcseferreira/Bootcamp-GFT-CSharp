partial class Program
{
    static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Lucas";
        p1.Idade = 24;
        p1.EnderecoPessoa = new Endereco()
        {
            Logradouro = "Rua Teste",
            Numero = 32,
            CEP = "00000",
            Cidade = "Ribeirão Preto"
        };
    }


}