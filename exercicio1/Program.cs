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
