using System;
class Operadores
{
    public static void Comparador()
    {
        int a = 5;
        int b = 50;
        //Operadores relacionais
        if (a > b) Console.WriteLine("A maior que B");
        else if (a < b) Console.WriteLine("B maior que A");
        else Console.WriteLine("A é igual a B");

        //Operadores de igualdade
        if (a == b) Console.WriteLine("Valores iguais");
        else Console.WriteLine("Diferentes");

        if (a != b) Console.WriteLine("A diferente de B");
        else Console.WriteLine("Iguais");
    }
}