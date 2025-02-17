int idade = 17;
bool autorizacao = false;

if (idade < 18 )
{
    if(autorizacao)
    {
        Console.WriteLine($"entrada liberada");
    }
    else
    {
        Console.WriteLine("entrada não permitida");
    }
}
else if (idade >= 18 )
{
    Console.WriteLine($"entrada liberada");
}

//atividade da presença minima//
int presenca = 7;
bool  presencaminima = false;

if (presenca <= 7 )
{
    if(presencaminima)
    {
        Console.WriteLine($"aprovado");
    }
    else
    {
        Console.WriteLine("entrada não permitida");
    }
}
else if (idade >= 7)
{
    Console.WriteLine($"entrada liberada");
}
