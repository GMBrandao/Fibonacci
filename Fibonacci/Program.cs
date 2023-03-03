long position, n1 = 0, n2 = 1;

Console.WriteLine("Digite quantos termos a sequência de Fibonacci terá:");
if (!long.TryParse(Console.ReadLine(), out position))
{
    Console.WriteLine("Por favor digite um número válido!");
}
else
{
    Console.WriteLine("Sequência de Fibonacci:");
    if (position > 0)
    {
        while (position > 0)
        {
            Console.Write(n2 + ", ");
            n2 += n1;
            n1 = n2 - n1;
            position--;
        }
    }
    else
        Console.WriteLine("Número inválido");
}