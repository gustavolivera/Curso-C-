// See https://aka.ms/new-console-template for more information
using Exercicio1;
using System.Globalization;

ContaBancaria conta;
Console.Write("Entre o número da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá depósito inicial? (s/n) ");
char resp = char.Parse(Console.ReadLine());

if(resp == 's' || resp == 'S')
{
    Console.Write("Entre o valor de depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new ContaBancaria(numero, titular, depositoInicial);
}
else
{
    conta = new ContaBancaria(numero, titular);
}

Console.WriteLine();
Console.WriteLine("Dados da conta: ");
Console.WriteLine(conta);
