//2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores
//(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...),
//escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci
//e retorne uma mensagem avisando se o número informado pertence ou não a sequência.


Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
if (int.TryParse(Console.ReadLine(), out int numero))
{
    if (IsFibonacci(numero))
        Console.WriteLine($"{numero} pertence à sequência de Fibonacci!");
    else
        Console.WriteLine($"{numero} NÃO pertence à sequência de Fibonacci.");
}
else
{
    Console.WriteLine("Por favor, insira um número válido.");
}

static bool IsFibonacci(int num)
{
    if (num == 0 || num == 1) return true;

    int a = 0, b = 1, c = 0;

    while (c < num)
    {
        c = a + b;
        a = b;
        b = c;
    }

    return c == num;
}