namespace Classes;

// Só podemos herdar de uma classe base
public class Ponto3D : Ponto
{
    public int z;

    public Ponto3D(int x, int y, int z) : base(x, y)
    {
        this.z = z;
        CalcularDistancia();
    }

    // Método extra da classe derivada
    public void Calcular() { }

    // Método sobrescrito da classe base
    public override void CalcularDistanciaVirtual() { }
}