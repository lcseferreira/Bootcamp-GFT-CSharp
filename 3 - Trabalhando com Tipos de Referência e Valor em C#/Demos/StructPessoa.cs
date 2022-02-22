public struct StructPessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Documento { get; set; }

    public void MudarNomePessoa(StructPessoa p1, string nome)
    {
        p1.Nome = nome;
    }
}
