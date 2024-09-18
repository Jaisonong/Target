using System.Runtime.Serialization.Formatters;
using System.Threading.Channels;

Console.WriteLine("Insira uma palavra: ");
string palavra = Console.ReadLine();

for (int i = palavra.Length - 1; i >= 0; i--)
{
    Console.Write(palavra[i]);
}
