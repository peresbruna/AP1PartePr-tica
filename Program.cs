bool continuar = true; // -->  Essa váriavel é usada para controlar o loop do-while
do // --> Enquanto o while for verdadeiro ele irá executar o código a baixo
{
Console.WriteLine("Digite seu nome:"); // --> Solicita que o usuário digite um nome 
string? nome = Console.ReadLine(); // --> E o nome informado ficará armazenado na váriavel nome ()

Console.WriteLine("Informe sua idade:"); // --> Solicita que o usuário digite a sua idade 
int idade = Convert.ToInt32(Console.ReadLine()); // --> E a idade informada será convertida para um número inteiro e ficará armazenado na váriavel idade

Console.WriteLine("Digite seu peso:"); // --> Solicita que o usuário digite o seu peso 
double peso = Convert.ToDouble(Console.ReadLine()); // --> E o peso informado será convertido para um número flutuante e ficará armazenado na váriavel peso

Console.WriteLine("Digite sua altura:"); // --> Solicita que o usuário digite sua altura 
double altura = Convert.ToDouble(Console.ReadLine()); // --> E a altura informada será convertida para um número flutuante e ficará armazenado na váriavel altura

double imc = peso / (altura * altura); // --> Pega os dados inseridos pelo usuário em peso e altura, e faz o cálculo do IMC
Console.WriteLine($"Seu IMC é {imc}");  // --> Mostra o resultado do cáculo do IMC feito acima usando a interpolação de string

string categoriaIMC; // --> Declara uma varíavel para armazenar as categorias do IMC (Abaixo do peso, peso normal, sobrepeso e obesidade)
// Abaixo foi usado if, else e elseif para determinar as categorias do IMC e mostrar o resultado no relatório final

if (imc < 18.5) 
{
    categoriaIMC = "você está abaixo do peso"; 
}
else if (imc >= 18.5 && imc < 25) //
{
    categoriaIMC = "você está com o peso normal"; 
}
else if (imc >= 25 && imc < 30) 
{
    categoriaIMC = "você está com sobrepeso"; 
}
else 
{
    categoriaIMC = "você está com obesidade"; 
}
string faixaEtaria; // --> Declara uma varíavel para armazenar a faixa etária (Criança, adolescente, adulto e idoso)
// Abaixo foi usado if, else e elseif para determinar a faixa etária do usuário e mostrar o resultado no relatório final

if (idade < 12) 
{
    faixaEtaria = "Criança"; 
}
else if (idade >= 13 && idade < 17) 
{
    faixaEtaria = "Adolescente"; 
}
else if (idade >= 18 && imc < 65) 
{
    faixaEtaria = "Adulto"; 
}
else 
{
    faixaEtaria = "Idoso"; 
}

Console.WriteLine("\nRelatório:"); // --> Imprimi no terminal "Relátorio:"
Console.WriteLine("Seu nome é " + nome + " e você tem " + idade +  " anos") ; // --> Usando a concatenação irá imprimir no terminal: "Seu nome é ... e você tem ... anos" 
Console.WriteLine($"Seu IMC: {imc} e {categoriaIMC}, sua faixa etária se encaixa na categoria: {faixaEtaria}"); // --> Usando a interpolação irá imprimir no terminal "Seu IMC: ... e ..., sua faixa etária se encaixa na categoria: ..." 
Console.WriteLine("\nDeseja gerar um novo relatório? (Sim/Não)"); // --> Imprimi no terminal a pergunta se o usuário deseja calcular o IMC e gerar o relatório novamente

string? resposta = Console.ReadLine(); // --> Aqui a resposta será atribuida a variável "continuar"

continuar = (resposta?.ToLower() == "Sim"); // --> Caso a resposta seja sim o programa será executado novamente

} while (continuar); // --> Enquanto a variavel for verdadeira (true) continuará repetindo as perguntas e o relátorio

Console.WriteLine("Programa encerrado."); // --> Caso a resposta não seja verdadeira (false) o programa será encerrado e aparecerá a mensagem "Programa encerrado."