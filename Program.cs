using Códigos.Models;


Calculadora calc = new Calculadora();

int numero = 10;

Console.WriteLine($"{numero} x 1 = {numero * 1}");

for(int contador = 0; contador <= 10; contador++){
    Console.WriteLine($"contador {contador}");
}








//int numeroincremento = 1;

//Console.WriteLine($"O número com incrento {numeroincremento}");
//numeroincremento++;

//Console.WriteLine($"O número com incrento {numeroincremento}");
//int decremento = 20;
//decremento--;
//Console.WriteLine($"Escreva esse núemro como decremento de {decremento}");
//calc.Raizquadrada(20);



//calc.Somar(5, 5);
//calc.Subtração(50, 60);
//calc.Divisão(20, 10);
//calc.Multiplicação(5, 20);
//calc.Potencia(3, 3);
//calc.Coseno(30);
//calc.Seno(40);
//calc.Tangente(50);







//bool choveu = false;
//bool estatarde = true;

//if(!choveu && !estatarde){
//    Console.WriteLine("Vou pedalar!!");
//}
//else{
//    Console.WriteLine("Vou pedalar outro dia!!");
//}






//bool ehMaiorDeIdade = true;
//bool possuiAutorizacaoDoResponsavel = false;

//operador and && bool possuiPresencaMinima = true;
//double media = 7.5;


//if(possuiPresencaMinima && media >= 7){
//    Console.WriteLine("Aluno aprovado");
//}
//else{
//    Console.WriteLine("Aluno Reprovado");
//}








//Operador OR || if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel){ // A varíavel OR ou verifica se uma das alternativas é verdadeira se for continua a validação ||
//    Console.WriteLine("Entrada liberada");
//}
//else{
//    Console.WriteLine("Entrada não liberada");
//}














//Console.WriteLine("Digite uma letra");
//string letra = Console.ReadLine();

//switch(letra)
//{
//    case "a":
//    case "e":
//    case "i":
//    case "o":
//    case "u":
//         Console.WriteLine("Vogal");
//         break;

//    default:
//        Console.WriteLine("Não é uma vogal");
//        break;
//}








//if( letra == "a" || 
    //letra == "e" ||
    //letra == "i" ||
    //letra == "o" ||
    //letra == "u")
    //{
    //    Console.WriteLine("Vogal");
    //}
//else{
//    Console.WriteLine("Não é vogal");
//}
//if(letra == "a")
//{
//    Console.WriteLine("Vogal");
//}
//else if(letra == "e")
//{
//    Console.WriteLine("Vogal");
//}
//else if (letra == "i")
//{
//    Console.WriteLine("Vogal");
//}
//else if (letra == "o")
//{
//    Console.WriteLine("Vogal");
//}
//else if (letra == "u")
//{
//  Console.WriteLine("Vogal");
//}










//int quantidade_estoque = 10;
//int quantidade_venda = 0;
//bool respostavenda = quantidade_venda > 0 && quantidade_estoque >= quantidade_venda;

//Console.WriteLine($"quantidade_estoque: {quantidade_estoque}");
//Console.WriteLine($"quantidade_estoque: {quantidade_venda}");
//Console.WriteLine($"Posso realizar a venda ? {respostavenda}");

//if(quantidade_venda == 0)
//{
//    Console.WriteLine("Venda inválida");
//}

//else if(respostavenda){
//    Console.WriteLine("A venda foi realizada com sucesso");
//}
//else{
//    Console.WriteLine("Desculpe mais a venda foi mal sucedida");
//}




//string a = "15 -";
//int b = 0;
//int.TryParse(a, out int b);

//Console.WriteLine(b);
//Console.WriteLine("Teste sucesso");





//int a = 5;
//double b = a;

//int a = 5;
//long b = a;


//int a = long.MaxValue;
//long b = Convert.ToInt32(a);

//int a = int.MaxValue; // O valor máximo de um inteiro é dois bilhões - Inteiro bilhões e Long Trilhões
//long b = a; // Int cabe no long mais long não cabe no int, porque o valor extrapolha e dar Overflow exception - execeção memória estourada

//Console.WriteLine(b);

//Casting é a conversão de um tipo primitivo de um tipo para outro tipo.


//int a = Convert.ToInt32("5");
//int a = int.Parse("Sc");
//Console.WriteLine(a);
//int inteiro = 5;
//string a = inteiro.ToString();

//Console.WriteLine(a);



//int a = 30;
//int b = 40;

//int c = a+b;

//c = c + 50; Soma o valor

//c += 5; Soma o valor - forma reduzida
 //c -= 50; subtrai o valor de forma reduzida


//Console.WriteLine(c);





//string apresentacao= "Olá seja bem vindo"; //Variavel
//int quantidade = 1;// Variavel
//double altura = 1.80;
//decimal preco = 1.80m;
//bool condicao = true;

//Console.WriteLine(apresentacao);
//Console.WriteLine("Valor da quantidade: "+quantidade);  
//Console.WriteLine("Valor da altura:" + altura.ToString("0.00"));//.ToString("0,00") fazer o tratamento dos dados e indicar quais casas decimais devem ser usadas
//Console.WriteLine("Valor do preço: "+ "R$"+preco);
//Console.WriteLine("Valor da condição: "+condicao);
//DateTime dataAtual = DateTime.Now; // Função DateTime mostrar a hora e data em tempo real ---
//Console.WriteLine(dataAtual);
//Variavel é um pedaço da memória que você pode amarzenar um valor durante a execução de um código


//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Davy";
//pessoa1.Idade = 26;
//pessoa1.Altura = 1.70;
//pessoa1.Apresentar();// vai usar a função apresentar para entregar as informações requeridas na aba Pessoa.cs