Console.WriteLine("Digite dois números inteiros");
string entrada1 = Console.ReadLine() ?? "";
string entrada2 = Console.ReadLine() ?? "";

if (int.TryParse(entrada1, out int primeiroNumero) && int.TryParse(entrada2, out int segundoNumero))
{
    Console.WriteLine($"Números digitados: {primeiroNumero} e {segundoNumero}\n");

    int somaDosNumeros = primeiroNumero + segundoNumero;
    int subtracaoDosNumeros = primeiroNumero - segundoNumero;
    int multiplicacaoDosNumeros = primeiroNumero * segundoNumero;
    double divisaoDosNumeros;
    if (primeiroNumero != 0 && segundoNumero != 0)
    {
        divisaoDosNumeros = primeiroNumero / segundoNumero;
    }
    else
    {
        divisaoDosNumeros = 0;
    }

    Console.WriteLine($"Soma dos dois números: {somaDosNumeros}");
    Console.WriteLine($"Subtracao dos dois números: {subtracaoDosNumeros}");
    Console.WriteLine($"Multiplicação dos dois números: {multiplicacaoDosNumeros}");
    Console.WriteLine($"Divisão dos dois números: {divisaoDosNumeros}");
}
else
{
    Console.WriteLine("Números inválidos");
}   

