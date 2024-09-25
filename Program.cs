using Códigos.Models;

string apresentacao= "Olá seja bem vindo"; //Variavel
int quantidade = 1;// Variavel
double altura = 1.80;
decimal preco = 1.80m;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da quantidade: "+quantidade);  
Console.WriteLine("Valor da altura:" + altura.ToString("0.00"));//.ToString("0,00") fazer o tratamento dos dados e indicar quais casas decimais devem ser usadas
Console.WriteLine("Valor do preço: "+ "R$"+preco);
Console.WriteLine("Valor da condição: "+condicao);
DateTime dataAtual = DateTime.Now; // Função DateTime mostrar a hora e data em tempo real ---
Console.WriteLine(dataAtual);
//Variavel é um pedaço da memória que você pode amarzenar um valor durante a execução de um código


Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Davy";
pessoa1.Idade = 26;
pessoa1.Altura = 1.70;
pessoa1.Apresentar();// vai usar a função apresentar para entregar as informações requeridas na aba Pessoa.cs