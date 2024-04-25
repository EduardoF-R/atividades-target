using System;

string frase = "Olá!!!";

string reversestring = "";
int tamanhoFrase;

//para invertermos a string primeiro contamos o tamanho da string.
tamanhoFrase = frase.Length - 1;

/*baseado no tamanho da string, o loop começa a rodar e começa a acrescentar os caracteres um por um desde o último index
até o primeiro.*/
while (tamanhoFrase >= 0)
{
    reversestring = reversestring + frase[tamanhoFrase];
    tamanhoFrase--;
}
Console.WriteLine(reversestring);
