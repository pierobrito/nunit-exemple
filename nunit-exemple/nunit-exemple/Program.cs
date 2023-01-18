using nunit_exemple.Extensions;
using System.Diagnostics.CodeAnalysis;

[ExcludeFromCodeCoverage]
internal class Program
{
    private static void Main(string[] args)
    {

        string? cpf = null;
        cpf?.ToNumbers();       

        Console.ReadLine();
    }
}