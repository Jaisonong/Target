Console.Write("Informe um número: ");
int numero = int.Parse(Console.ReadLine());

int a = 0, b = 1, c = 0;

while (c < numero)
{
    c = a + b;
    a = b;
    b = c;
}


if (c == numero || numero == 0)
{
    Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
}
else
{
    Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
}