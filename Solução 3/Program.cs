/*
 Escreva uma função que receba um inteiro ie retorne uma string com o inteiro invertido seguido pelo inteiro original.

Para ilustrar:

"123"
Invertemos "123"para obter "321"e depois adicionamos "123"ao final, resultando em "321123".

Exemplos
ReverseAndNot(123) ➞ "321123"

ReverseAndNot(152) ➞ "251152"

ReverseAndNot(123456789) ➞ "987654321123456789"
 */

Console.WriteLine(ReverseAndNot(123));
Console.WriteLine(ReverseAndNot(152));
Console.WriteLine(ReverseAndNot(123456789));

string ReverseAndNot(int num)
{
    string str = "";
    int aux = num;
    while(num != 0)
    {
        str += (num % 10);
        num /= 10;
    }
    str += aux;
    return str;
}