int[] meuArray = {1, 2, 3, 4, 5} ;
foreach (int i in meuArray)
{
    Console.WriteLine(i);  // imprime os valores do array
}

//estrutura de dados lista//
List<string> listaNomes = new List<string> {"wanderson","jeane","Ryan"};
listaNomes.Add("Maria");
foreach (string nome in listaNomes)
{
    Console.WriteLine(nome);
}
Console.WriteLine("");
//remover

listaNomes.Remove("Ryan");
foreach (string nome in listaNomes)
{
    Console.WriteLine(nome);
}
Console.WriteLine("");
//conjunto(set)//
HashSet<int> conjunto = new HashSet<int>{1,2,3,};
conjunto.Add(4);

foreach (int numero in conjunto)
{
    Console.WriteLine(numero);
}
Console.WriteLine("");
HashSet<int> conjunto2 = new HashSet<int>{1,2,3,};
conjunto.Add(5);

foreach (int numero1 in conjunto)
{
    Console.WriteLine(numero1);
}