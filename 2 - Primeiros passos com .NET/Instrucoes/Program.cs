namespace Instrucoes
{
    class Program
    {
        static void Main()
        {
            string[] meuArrayDeNomes = { "Lucas", "Eduardo", "Renata" };

            Declaracoes();
            InstrucaoIf(meuArrayDeNomes);
            InstrucaoSwitch(meuArrayDeNomes);
            InstrucaoWhile();
            InstrucaoDo();
            InstrucaoFor();
            InstrucaoForEach();
            InstrucaoBreak();
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

        static void InstrucaoSwitch(string[] args)
        {
            int numeroDeArgumentos = args.Length;

            switch (numeroDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("1 argumento.");
                    break;
                default:
                    Console.WriteLine($"{numeroDeArgumentos} argumentos.");
                    break;
            }
        }

        static void InstrucaoWhile()
        {
            int contador = 1;

            while (contador <= 10)
            {
                Console.Write($"{contador} ");
                contador++;
            }
        }

        static void InstrucaoDo()
        {
            string texto;

            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            } while (!string.IsNullOrEmpty(texto));
        }

        static void InstrucaoFor()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"For: {i}");
            }
        }

        static void InstrucaoForEach()
        {
            string[] nomes = { "Lucas", "Eduardo", "Ferreira" };

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }

        static void InstrucaoBreak()
        {
            while (true)
            {
                string nome = Console.ReadLine();

                if (string.IsNullOrEmpty(nome))
                {
                    break;
                }

                Console.WriteLine(nome);
            }
        }
    }
}