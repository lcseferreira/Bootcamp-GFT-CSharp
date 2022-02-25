Console.WriteLine("Digite o total de linhas:");
var n = int.Parse(Console.ReadLine());

int inicio = 1;

// for (int i = 0; i < n; i++)
// {
//     var quadrado = inicio * inicio;
//     var cubo = inicio * inicio * inicio;

//     Console.WriteLine($"{inicio} {quadrado} {cubo}");

//     inicio++;
// }

for (int i = 0; i < n; i++)
{
    var quadrado = Math.Pow(inicio, 2);
    var cubo = Math.Pow(inicio, 3);

    Console.WriteLine($"{inicio} {quadrado} {cubo}");

    inicio++;
}