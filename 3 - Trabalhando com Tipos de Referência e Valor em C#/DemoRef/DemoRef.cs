partial class Program
{
    static void DemoRef()
    {
        int a = 5;

        Adicionar20(a);

        System.Console.WriteLine($"Demo Value Type: O valor de a é {a}");

        // Passando o tipo valor por referência
        Adicionar20Ref(ref a);

        System.Console.WriteLine($"Demo ref: O valor de a é {a}");


        static void Adicionar20(int a)
        {
            a += 20;
        }

        // Pegando o parâmetro por referência
        static void Adicionar20Ref(ref int a)
        {
            a += 20;
        }
    }
}