namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        Ponto meuPonto = new Ponto(x: 8, y: 10);
        Ponto3D meuPonto3D = new Ponto3D(x: 2, y: 6, z: 4);

        meuPonto.CalcularDistancia();
        meuPonto3D.Calcular();
    }
}