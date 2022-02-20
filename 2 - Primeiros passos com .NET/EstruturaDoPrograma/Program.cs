namespace EstruturaDoPrograma
{
    class Program
    {
        static void Main()
        {
            var minhaPilha = new Pilha();

            minhaPilha.Empilhar(2);
            minhaPilha.Empilhar(6);
            minhaPilha.Empilhar(4);
            System.Console.WriteLine(minhaPilha.Desempilhar());
            System.Console.WriteLine(minhaPilha.Desempilhar());
            System.Console.WriteLine(minhaPilha.Desempilhar());
        }
    }
}