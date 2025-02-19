﻿// exercicio 1

int soma = 0;

for (int i = 0; i <= 101; i++ )
{
    if (i % 2 == 0)
    {
        soma = soma + i;
    }
    Console.WriteLine(soma);

}


// exercicio 2 contagem regressiva

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("Decolar");

// crie um algoritmo que conte o numero de vogais na palavra e exiba o resultado

string palavra = "algoritmo";
int contadorVogais = 0;

foreach (char letra in palavra)
{
    if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
    {
        contadorVogais++;
    }
}

Console.WriteLine($"A palavra '{palavra}' tem {contadorVogais} vogais.");


//crie um algoritmo que solicite uma palavra ou frase do usuário, e verifique se é um palíndromo, ou seja, se é igual de trás para frente

string frase = "A man, a plan, a canal, Panama!";
string somenteLetras = "";

foreach (char letra in frase)
{
    if (char.IsLetter(letra))
    {
        somenteLetras += char.ToLower(letra);
    }
}

char[] letrasArray = somenteLetras.ToCharArray();
        Array.Reverse(letrasArray);
        string invertido = new string(letrasArray);

        if (somenteLetras == invertido)
        {
            Console.WriteLine("É um palíndromo!");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo.");
        }

//Crie um algoritmo onde o cumputador escolhe um número aleatório entre 1 e 100, e o usário deve adivinhar. Após cada tentativa, o programa indica se o numero é maior ou menor
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); // Gera um número aleatório entre 1 e 100
        int palpite = 0;
        int tentativas = 0;

        Console.WriteLine("Tente adivinhar o número que estou pensando! (Entre 1 e 100)");

        while (palpite != numeroSecreto)
        {
            Console.Write("Digite seu palpite: ");
            string? entrada = Console.ReadLine();

            // Valida se a entrada é um número inteiro
            if (!string.IsNullOrEmpty(entrada) && int.TryParse(entrada, out palpite))
            {
                tentativas++;

                if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior! Tente novamente.");
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("O número secreto é menor! Tente novamente.");
                }
                else
                {
                    Console.WriteLine($"Parabéns! Você acertou o número {numeroSecreto} em {tentativas} tentativas.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido.");
            }
        }