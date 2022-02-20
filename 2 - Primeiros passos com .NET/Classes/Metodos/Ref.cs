namespace Classes.Metodos;

public class Ref
{
    // Recebendo valores por referência
    static void Inverter(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    static void Inverter()
    {
        int i = 1, j = 2;
        Inverter(ref i, ref j);
        Console.WriteLine($"{i} {j}");
    }
}