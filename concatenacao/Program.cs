string nome1 = "Marcos";
string saudacao1 = "olá " + nome1 + "! Bem-vindo";
Console.WriteLine(saudacao1);

string nome2 = "joão";
string saudacao2 = $"olá,   {nome2} ! Bem-vindo";
Console.WriteLine(saudacao2);

double numero = 10.10;
Console.WriteLine(numero.GetType());

Console.WriteLine(typeof(int));

string valorTexto = "100";
Console.WriteLine("A variavel valorTexto é do tipo :" + valorTexto.GetType());

int numero3 = int.Parse(valorTexto);
Console.WriteLine( numero3);
Console.WriteLine("A variavel numeroParse é do tipo :" + numero3.GetType());

string valoremTexto = "100";
Console.WriteLine("A variavel valorTexto é do tipo :" + valoremTexto.GetType());

int numeroConvertido = Convert.ToInt32(valorTexto);
Console.WriteLine( numeroConvertido);
Console.WriteLine("A variavel numeroConvertido é do tipo :" + numeroConvertido.GetType());


