//usamos o namespace .linq para utilizarmos alguns métodos úteis
using System.Linq;

/*A questão A contém apenas números ímpares, então neste exemplo se o último elemento do array não for divísivel por 2, ele usará o 
valor do último elemento + 2 e adicionar na variável resultado.*/
int[] questãoA = {1, 3, 5, 7};
int ultimoElementoA = questãoA.Last();

if (ultimoElementoA % 2 != 0)
{
    int resultadoA = ultimoElementoA + 2;
    Console.WriteLine(resultadoA);
}


/* Na questão B, todo número é o último número da sequência multiplicado por dois, então pegamos o último elemento do array e multiplicamos este por dois.
*/
int[] questãoB = {2, 4, 8, 16, 32, 64};
int ultimoElementoB = questãoB.Last();

int resultadoB = ultimoElementoB * 2;
Console.WriteLine(resultadoB);


/* Nesta questão, cada termo é acrescentado um número ímpar sequencial, de zero para um ele aumenta 1, de um para quatro ele aumenta 3, de quatro para nove
ele aumenta 5 e assim por diante, logo somamos o número ímpar correspondente ao último elemento do array.*/
int[] questãoC = {0, 1, 4, 9, 16, 25, 36};
int ultimoElementoC = questãoC.Last();
int ímparAdicionado = 1;

for (int i = 1; i < questãoC.Length; i++)
{
    ímparAdicionado += 2;
}

int resultadoC = ultimoElementoC + ímparAdicionado;
Console.WriteLine(resultadoC);


/* Temos na questão D uma progressão aritmética em que a razão inicial começa em 12 e soma 8 a cada novo termo (4 - 16 a razão era 12, 16 - 36 a razão era 20),
então somamos o último elemento do array com o a razão correspondente para este termo.*/
int[] questãoD = {4, 16, 36, 64};
int ultimoElementoD = questãoD.Last();
int razão = 12;

for (int i = 1; i <questãoD.Length;i++)
{
    razão += 8;
}

int resultadoD = ultimoElementoD + razão;
Console.WriteLine(resultadoD);


/* na questão E temos uma sequência de fibonacci, que para descobrir o próximo termo basta somar os últimos dois termos.
*/
int[] questãoE = {1, 1, 2, 3, 5, 8};
int ultimoElementoE = questãoE.Last();
int penultimoElementoE = questãoE.Length - 1;

int resultadoE = ultimoElementoE + penultimoElementoE;
Console.WriteLine(resultadoE);

/* Nesta sequência todos os números começam com a letra D, logo o próximo termo será o número duzentos
*/
int[] questãoF = {2, 10, 12, 16, 17, 18, 19};
int ultimoElementoF = questãoF.Last();

int resultadoF = 200;
Console.WriteLine(resultadoF);
