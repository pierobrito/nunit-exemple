// See https://aka.ms/new-console-template for more information
using nunit_exemple.Helpers;

var cpf = "00081411189";
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
