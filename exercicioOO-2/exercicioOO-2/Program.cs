/*
Fazer um programa para ler nome e salário de dois funcionários. 
Depois, mostrar o salário médio dos funcionários.

Exemplo:

Dados do primeiro funcionário:
Nome: Carlos Silva
Salário: 6300.00
Dados do segundo funcionário:
Nome: Ana Marques
Salário: 6700.00
Salário médio = 6500.00
*/

using exercicioOO_2;
using System.Globalization;

Salario func1 = new Salario();
Salario func2 = new Salario();

Console.WriteLine("Dados do primeiro funcionário:");
Console.Write("Nome: ");
func1.NomeFunc = Console.ReadLine();
Console.Write("Salário: ");
func1.SalarioFunc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();
Console.WriteLine("Dados do segundo funcionário:");
Console.Write("Nome: ");
func2.NomeFunc = Console.ReadLine();
Console.Write("Salário: ");
func2.SalarioFunc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();
double salarioMedio = (func1.SalarioFunc + func2.SalarioFunc) / 2.0;
Console.WriteLine("Salario médio: " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));