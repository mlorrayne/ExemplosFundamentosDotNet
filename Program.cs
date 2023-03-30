// See https://aka.ms/new-console-template for more information

using ExemplosFundamentos2.Models;



//CÓDIGO 01
//Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Lorrayne";
// pessoa1.Idade = 29;
// pessoa1.Apresentar(); 


//CÓDIGO 02
// string apresentacao = "olá";
// int quantidade = 1;
// double altura = 1.50;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao + "\n");
// Console.Write("Valor da variável quantidade: " + quantidade + "\n");
// Console.Write("Valor da variável altura: " + altura.ToString("0.00") + "\n");
// Console.Write("Valor da variável preço: " + preco + "\n");
// Console.Write("Valor da variável condição: " + condicao + "\n");



//CÓDIGO 03
// int a = 10;
// int b = 20;
// int c = a + b;

// c = c + 5;
// c += 5 == c = c +5

//Console.WriteLine(c);




//CÓDIGO 04 - Cast ou Casting

//int a = Convert.ToInt32("5");
//Console.WriteLine(a);

//int a = int.Parse("5");
//Console.WriteLine(a);

//a diferença entre convert e parse é o tratamento de valores nulos
//Convert.ToInt32(null) = 0
//int.Parse(null) - gera erro porque não aceita valor nulo

//Comversão para String - utilizar .ToString()
//int inteiro = 5;
//string a = inteiro.ToString();

//Console.WriteLine(a);

//Coversão segura - TryParse

// string a = "15";
// int b = 0;

// void TryParse(string a, out int b)
// {
//     throw new NotImplementedException();
// }


//CODIGO 05 - CONDICIONAIS

// int quantidadeEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque>=quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0){
//     Console.WriteLine("Venda Inválida");
// }

// else if(possivelVenda)
// {
//     Console.WriteLine("Venda Realizada");
// }
// else{
//     Console.WriteLine("Desculpe, não temos a quantidade em estoque");
// }




//CODIGO 06 - sem switch case
// if (letra == "a" ||     // || = ou 
//     letra == "e" ||
//     letra == "i" ||
//     letra =="o"  ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }


//CODIGO 06 - Com switch case

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();


// switch(letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":

//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;

// }



//Codigo 07 - Operadores lógicos
// OR (Pipe ||)

// bool eMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if (eMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada Liberada!");
// }
// else{
//     Console.WriteLine("Entrada não liberada");
// }




//CODIGO 08 - Operador And (&&)

// bool possuiPresencaMinima = true;
// double media = 6.5;

// if (possuiPresencaMinima && media >7){
//     Console.WriteLine("Aluno Aprovado");

// }
// else{
//     Console.WriteLine("Reprovado");
// }




//CODIGO 09 - Not (!)

// bool choveu = false;
// bool estaTarde = false;


// o if sempre considera que a condição seja verdadeira
// se tem o sinal de Not na frente, a resposta esperada é false
// if (!choveu && !estaTarde){
//     Console.WriteLine("Vou pedalar");
// }
// else{
//     Console.WriteLine("Vou pedalar um outro dia");
// }




//CODIGO 10 
//Calculadora calc = new Calculadora();

//calc.Somar(3, 5);
// calc.Subtrair(20, 7);
// calc.Multiplicar(13, 5);
// calc.Dividir( 35, 7);
//calc.Potencia(3, 5);
//calc.RaizQuadrada(9);

// calc.Seno(30);
// calc.Cosseno(30);
// calc.Tangente(30);

// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("Incrementando o 10");
// numero ++;

// Console.WriteLine(numero);



//CÓDIGO 11 - LAÇOS DE REPETIÇÃO - FOR

// int numero = 5;
// for(int contador = 0; contador <=10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero*contador}");
// }




//CÓDIGO 12 - WHILE

// int numero = 5;
// int contador = 0;

// while(contador <=10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;
// }




//CÓDIGO 13 - DO WHILE

// int soma =0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;


// }while(numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");




//CÓDIGO 14 

// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();                           //limpa o console
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar cliente");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//         break;

//         case "2":
//             Console.WriteLine("Buscar de cliente");
//         break;

//         case "3":
//             Console.WriteLine("Apagar de cliente");
//         break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;             //sair do programa
//         break;

//         default:
//             Console.WriteLine("Opção Inválida");
//             break;


//     }
// }

// Console.WriteLine("O programa foi encerrado");




//CÓDIGO 15 - ARRAYS

// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;


// int[] arrayInteirosDobrado = new int[arrayInteiros.Length *2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


// //Percorrendo o array com o for
// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição nº {contador} - {arrayInteiros[contador]}");

// }

// Console.WriteLine("percorrendo o array com foreach");
// //foreach não precisa de contador
// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
//     Console.WriteLine($"Posição nº {contadorForeach} - {valor}");
//     contadorForeach++;

// }




//CÓDIGO 17 - LISTAS

// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");
// listaString.Add("RJ");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MG");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// for (int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição nº {contador} - {listaString[contador]}");

// }

// foreach (string item in listaString)
// {
//     Console.WriteLine(item);
// }







