//5) Escreva um programa que inverta os caracteres de um string.
//IMPORTANTE:
//a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
//b) Evite usar funções prontas, como, por exemplo, reverse;

Console.Write("Escreva uma string/frase que será invertida: ");
var input = Console.ReadLine();

if (input == null || input.Length <= 0)
    input = "Exemplo de string a ser invertida";

Console.WriteLine("Como você não digitou nada, usaremos a seguinte frase como exemplo: " + input);
Console.WriteLine();

string inverted = InverterString(input);

Console.WriteLine("String invertida: " + inverted);

static string InverterString(string input)
{
    char[] array = input.ToCharArray();
    int left = 0;
    int right = array.Length - 1;

    while (left < right)
    {
        char temp = array[left];
        array[left] = array[right];
        array[right] = temp;

        left++;
        right--;
    }

    return new string(array);
}