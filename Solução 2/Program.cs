/*
SOLUÇÃO 2:
Crie uma função que receba uma única string como argumento e retorne uma matriz ordenada contendo os índices de todas as letras maiúsculas na string.

Exemplos
IndexOfCapitals("eDaBiT") ➞ [1, 3, 5]

IndexOfCapitals("eQuINoX") ➞ [1, 3, 4, 6]

IndexOfCapitals("determine") ➞ []

IndexOfCapitals("STRIKE") ➞ [0, 1, 2, 3, 4, 5]

IndexOfCapitals("sUn") ➞ [1]
 */

List<int> index = IndexOfCapitals("eQuINoX");
Printf(index);

index = IndexOfCapitals("determine");
Printf(index);

index = IndexOfCapitals("STRIKE");
Printf(index);

index = IndexOfCapitals("sUn");
Printf(index);

void Printf (List<int> indices)
{

    foreach (var n in index)
    {
        Console.Write(n);
    }
    Console.WriteLine();
}


List<int> IndexOfCapitals(string str)
{
    List<int> indexMaiusculas = new List<int>();
    int i = 0;
    foreach (char c in str)
    {
        if (char.IsUpper(c))
        {
            indexMaiusculas.Add(i);

        }
        i++;
    }
    return indexMaiusculas;
}