// Exercício 1: Soma dos elementos de um array
        int[] numerosArray = { 1, 2, 3, 4, 5 };
        int soma = numerosArray.Sum();
        Console.WriteLine("Soma dos elementos: " + soma);

        // Exercício 2: Contar quantas vezes "Jeane" aparece na lista
        List<string> nomes = new List<string> { "Jeane", "Wanderson", "Jeane", "Ryan", "Jeane" };
        int contagem = nomes.Count(nome => nome == "Jeane");
        Console.WriteLine("O nome 'Jeane' aparece " + contagem + " vezes.");

        // Exercício 3: Remover elementos duplicados da lista de inteiros
        List<int> numerosLista = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        List<int> listaSemDuplicatas = numerosLista.Distinct().ToList();
        Console.WriteLine("Lista sem duplicatas: " + string.Join(", ", listaSemDuplicatas));

        // Exercício 4: Verificar se "Banana" está no conjunto HashSet
        HashSet<string> frutas = new HashSet<string> { "Maçã", "Banana", "Laranja" };
        if (frutas.Contains("Banana"))
        {
            Console.WriteLine("'Banana' está no conjunto.");
        }
        else
        {
            Console.WriteLine("'Banana' não está no conjunto.");
        }

        // Exercício 5: Criar uma lista vazia e adicionar números de 1 a 5
        List<int> listaNumeros = new List<int>();
        for (int i = 1; i <= 5; i++)
        {
            listaNumeros.Add(i);
        }
        Console.WriteLine("Elementos da lista: " + string.Join(", ", listaNumeros));