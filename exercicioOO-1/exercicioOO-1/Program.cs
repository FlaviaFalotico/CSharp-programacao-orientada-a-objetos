/*
Fazer um programa para ler os dados de duas pessoas, 
depois mostrar o nome da pessoa mais velha.

Exemplo:
Dados da primeira pessoa:
Nome: Maria
Idade: 17

Dados da segunda pessoa:
Nome: Joao
Idade: 16
Pessoa mais velha: Maria 
*/
using exercicioOO_1;

Pessoa pessoa1; 
Pessoa pessoa2; 

pessoa1 = new Pessoa();
pessoa2 = new Pessoa();

Console.WriteLine("Dados da primeira pessoa:");
Console.WriteLine("Nome: ");
pessoa1.Nome = Console.ReadLine();
Console.WriteLine("Idade: ");
pessoa1.Idade = int.Parse(Console.ReadLine());
Console.WriteLine("Peso: ");
pessoa1.Peso = double.Parse(Console.ReadLine());
Console.WriteLine("Altura: ");
pessoa1.Altura = double.Parse(Console.ReadLine());

Console.WriteLine("Dados da primeira pessoa:");
Console.WriteLine("Nome: ");
pessoa2.Nome = Console.ReadLine();
Console.WriteLine("Idade: ");
pessoa2.Idade = int.Parse(Console.ReadLine());
Console.WriteLine("Peso: ");
pessoa2.Peso = double.Parse(Console.ReadLine());
Console.WriteLine("Altura: ");
pessoa2.Altura = double.Parse(Console.ReadLine());

pessoa1.exibirDados();
pessoa2.exibirDados();

int maisvelha = 0;
if (pessoa1.Idade > pessoa2.Idade)
{
    Console.WriteLine("Pessoa mais velha:" + pessoa1.Nome);
}
else
{
    Console.WriteLine("Pessoa mais velha:" + pessoa2.Nome);

}