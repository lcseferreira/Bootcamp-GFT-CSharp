namespace Classes.Metodos;

public class Out
{
    static void Dividir(int x, int y, out int resultado, out int resto)
    {
        resultado = x / y;
        resto = x % resto;
    }

    static void Dividir()
    {
        Dividir(10, 3, out int resultado, out int resto);
        Console.WriteLine($"{resultado} {resto}");
    }
}