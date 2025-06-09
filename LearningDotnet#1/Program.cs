using LearningDotnet_1.Models;

Pessoa p1 = new Pessoa();

p1.Nome = "John";
p1.Idade = 22;

p1.Apresentar();

string phase = "Hello";
int numero = 2;
double numeroDoisDecimal = 1.70;
decimal valorMonetario = 1.90M;
bool valorBool = false;

Console.WriteLine($"Apresentacao: {phase}");
Console.WriteLine($"valor interger {numero}");
Console.WriteLine($"valor movetario {valorMonetario}");
Console.WriteLine($"numero decimal {numeroDoisDecimal}");
Console.WriteLine($"numero dois decimal {numeroDoisDecimal.ToString("0.00")}");
Console.WriteLine($"valor Bool {valorBool}");

DateTime dataAgora = DateTime.Now;
Console.WriteLine(dataAgora.ToString("dd/MM/yyyy HH:mm"));

bool op = true;
string result = (op == true) ? "Verdadeiro" : "False";

Console.WriteLine($"Is: {result}");