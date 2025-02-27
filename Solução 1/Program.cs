/*
SOLUÇÃO 1: 
Dada uma string, crie uma função para inverter a caixa. Todas as letras minúsculas devem ser maiúsculas, e vice-versa.

Exemplos
ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"

ReverseCase("MANY THANKS") ➞ "many thanks"

ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"
 */

string teste = "Happy Birthday";
Console.WriteLine(ReverseCase(teste));
teste = "many thanks";
Console.WriteLine(ReverseCase(teste));
teste = "SpOnTaNeOuS";
Console.WriteLine(ReverseCase(teste));

string ReverseCase(string str)
{
    string str2 = "";
    foreach (var c in str)
    {
        if (char.IsUpper(c))
        {
            str2 += char.ToLower(c);
        }
        else
        {
            str2 += char.ToUpper(c);
        }
    }

    return str2;
}





