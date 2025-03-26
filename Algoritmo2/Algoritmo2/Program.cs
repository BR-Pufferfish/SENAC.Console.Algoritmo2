    //Variáveis no C#

int idade = 10;
string nomeCliente = "Puffer";
decimal preco = 10M;
//o "M" após o 10 é pra indicar que ele é decimal, mesmo não tendo pontuação (ex: 10.0)
char letra = 'p';
var nomeCompleto = "BR Puffer Fish";
var altura = 180;

Console.Write("Digite seu nome: ");
nomeCompleto = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Bem vindo " + nomeCompleto);
Console.WriteLine();
Console.Write("Digite sua Idade: ");
var linha = Console.ReadLine();
idade = int .Parse(linha);
Console.WriteLine("Idade informada " + idade);

Console.ReadKey();
//o Console quase sempre é do tipo ReadLine (para ler a informações) ou do tipo WriteLine (para inserir informações)