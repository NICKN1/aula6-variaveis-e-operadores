//Variáveis
string nome;
string idade;
string anoAtual;



Console.WriteLine("Digite o seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Digite a sua idade: ");
idade = Console.ReadLine();

Console.WriteLine("Digite o ano atual: ");
anoAtual = Console.ReadLine();

//Calculo com operador aritmético
int anoNasceu = Int32.Parse(anoAtual) - Int32.Parse(idade);

//Output com os dados!
Console.WriteLine($"Olá {nome}, você nasceu em {anoNasceu}");