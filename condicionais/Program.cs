//condicional IF//
int numero = 10;
if (numero > 0)
{
Console.WriteLine("O numero é positivo");
}

// condicional ELSE IF//

double nota1 = 5.5;
double nota2 = 8.0;
double nota3 = 6.8;
double media = (nota1 + nota2 + nota3)/3;
if (media >= 7)
{
Console.WriteLine($"média{media:F2}Aprovado");
}
else
{
Console.WriteLine($"média{media:F2}Reprovado");
}

double nota4 = 5.5;
double nota5 = 8.0;
double nota6 = 6.8;
double mediaNota = (nota4 + nota5 + nota6)/3;
if (media >= 7)
{
Console.WriteLine($"média{media:F2}Aprovado");
}
else if (mediaNota >= 5 && mediaNota <7)
{
Console.WriteLine($"média{media:F2}Recuperacao");
}
else
{
Console.WriteLine($"média{media:F2}Recuperacao");
}

//condicionais if else if//
Console.WriteLine(" Digite uma letra");
string letra = Console.ReadLine();

if (letra == "a" || letra == "A")
{
Console.WriteLine($"a letra {letra} é uma vogal.");
}

else if (letra == "e" || letra == "E")
{
Console.WriteLine($"a letra {letra} é uma vogal.");
}

else if (letra == "i" || letra == "I")
{
Console.WriteLine($"a letra {letra} é uma vogal.");
}

else if (letra == "o" || letra == "O")
{
Console.WriteLine($"a letra {letra} é uma vogal.");
}

else if (letra == "u" || letra == "U")
{
Console.WriteLine($"a letra {letra} é uma vogal.");
}
else
{
Console.WriteLine($"a letra {letra} não é uma vogal.");
}
//condicional switch//
string dia = "segunda";
switch (dia)
{
    case "segunda":
        Console.WriteLine("começo da semana");
        break;
    case"sexta":
        Console.WriteLine("fim da semana chegando");
        break;
    default:
        Console.WriteLine("dia qualquer");
        break;
}
//condicional case com escrita
Console.WriteLine("digite uma letra");
string letra3 = Console.ReadLine();
string letraMinuscula = letra3.ToLower();
switch (letraMinuscula)
{
    case"a":
    case"e":
    case"i":
    case"o":
    case"u":
        Console.WriteLine($"a letra {letraMinuscula} é uma vogal.");
        break;
    default:
        Console.WriteLine($"a letra {letraMinuscula} NÃO é uma vogal.");
        break;
}
// condicionais: operador ternário//

int idade = 18;
string mensagem = idade >= 18 ? "Maior de idade" : "Menor de idade";
Console.WriteLine(mensagem);


