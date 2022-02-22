public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Documento { get; set; }

    public Pessoa() { }
    public Pessoa(string nome, int idade, string documento)
    {

        Nome = nome;
        Idade = idade;
        Documento = documento;
    }

}