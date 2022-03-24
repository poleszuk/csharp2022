// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Escreva seu nome Completo");
string nome = Console.ReadLine();
Console.WriteLine("Quantos Quartos tem na sua Casa");
int quarto = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o preço de um Produto");
double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Digite seu Ultimo Nome, Idade e Altura");
string[] vet = Console.ReadLine().Split(' ');

string nome2 = vet[0];
int idade = int.Parse(vet[1]);
double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

Console.WriteLine("Você digitou:");

Console.WriteLine(nome);
Console.WriteLine(quarto); 
Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(nome2);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));