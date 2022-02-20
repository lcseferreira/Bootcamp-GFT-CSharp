namespace Instrucoes
{
    class Program
    {
        static void Main()
        {
            string[] meuArrayDeNomes = { "Lucas", "Eduardo", "Renata" };

            Declaracoes();
            InstrucaoIf(meuArrayDeNomes);
        }

        static void Declaracoes()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a + b + c + d);
        }

        static void InstrucaoIf(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento.");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("1 argumento.");
            }
            else
            {
                Console.WriteLine($"{args.Length} argumentos.");
            }
        }
    }
}