Random numeroAleatorio = new Random();
int numero=numeroAleatorio.Next();
int contador = 0;
Console.WriteLine($"Numero Alvo: {numero}");
while(contador <= numero)
{
    Console.WriteLine($"Contador: {contador}.");
}
Console.WriteLine($"Contador atingiu o número alvo: {contador}");

// estrutura de repetição do while//
int numero1 = 0;

do
{
    Console.WriteLine($"Númer1: {numero1}");
    numero1++;
}while(numero1 <10);

// estrutura de repetição for//
for(int i = 0; i <= 10; i++)
{
    Console.WriteLine($"Valor de i: {i}");
}

// estrutura de repetição foreach//

string[] nomes = {"Marcos", "Matheo", "Daniel"};

foreach(string nome in nomes)
{
    Console.WriteLine($"Nome: {nome}");
}
