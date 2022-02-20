namespace Classes;

public class Ponto
{
    // Campos / Atributos
    public int x, y;
    private int _distancia;

    // Construtor
    public Ponto(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    // Métodos
    public void CalcularDistancia() { }

    public virtual void CalcularDistanciaVirtual() { }
}