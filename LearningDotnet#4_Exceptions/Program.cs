
using LearningDotnet.Models;

string[] linhas = File.ReadAllLines("./Arquivos/Arquivo.txt");

foreach (string linha in linhas)
{
    Console.WriteLine(linha);
}

Console.WriteLine("\nUsando Try...Catch\n");

try
{
    linhas = File.ReadAllLines("./Arquivos/ArquivoComNomeErrado.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException excep)
{
    Console.WriteLine($"Arquivo nao encontrado. {excep.Message}");
}
catch (DirectoryNotFoundException excep)
{
    Console.WriteLine($"Caminho para Arquivo nao encontrado. {excep.Message}");
}
catch (Exception excep)
{
    Console.WriteLine($"Encontrado uma excecao. {excep.Message}");
}
finally
{
    Console.WriteLine("A Tentativa foi executada com sucesso.");
}

Console.WriteLine("\nExcecao Artificial\n");

new ExemploException().Metodo1();