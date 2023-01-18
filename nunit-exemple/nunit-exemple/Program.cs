// See https://aka.ms/new-console-template for more information
using nunit_exemple.Helpers;
using System.Diagnostics.CodeAnalysis;

[ExcludeFromCodeCoverage]
internal class Program
{
    private static void Main(string[] args)
    {

        var cpf = "auhiuiahuihauihauihaui00081411189";
        Console.WriteLine($"Validate cpf : {cpf} ");

        if (ValidateCPF.IsCpf(cpf))
        {
            Console.WriteLine($"{cpf} is valid");
        }
        else
        {
            Console.WriteLine($"{cpf} is not valid");
        }

        Console.ReadLine();
    }
}