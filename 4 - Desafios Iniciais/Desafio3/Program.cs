Console.WriteLine("Digite um número ou 0 para sair:");
var numero = int.Parse(Console.ReadLine());

while (numero != 0)
{
    int soma, aux;

    if (numero % 2 == 0)
    {
        soma = numero;
        aux = soma + 2;
        for (int i = 0; i < 4; i++)
        {
            soma += aux;
            aux += 2;
        }
        Console.WriteLine(soma);
    }
    else
    {
        soma = numero + 1;
        aux = soma + 2;
        for (int i = 0; i < 4; i++)
        {
            soma += aux;
            aux += 2;
        }
        Console.WriteLine(soma);
    }

    Console.WriteLine("Digite um número ou 0 para sair:");
    numero = int.Parse(Console.ReadLine());
}