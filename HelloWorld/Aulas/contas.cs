using System;
public class contas
{
    public static void soma()
    { 
        int a = 10;
        int b = 2;
        int resultado = a + b;
        Console.WriteLine("Soma: " + resultado);
    }
    public static void multiplicacao()
    {
        int a = 10;
        int b = 2;
        int resultado = a * b;
        Console.WriteLine("Mutiplicação: " + resultado);
    }
    public static void divisao()
    {
        int a = 15;
        int b = 2;
        
        decimal resultado = Convert.ToDecimal(a) / Convert.ToDecimal(b);
        Console.WriteLine("Divisão de dois inteiro convertidos para o decimal");
        Console.WriteLine("Divisão: " + resultado);

        int div = a / b;
        int resto = a % b;
        Console.WriteLine("Divisão resultado inteiro e o resto da divisão");
        Console.WriteLine("Resultado: " + div + " Resto: " + resto);
    }
    public static void subtracao()
    {
        int a = 10;
        int b = 2;
        int resultado = a - b;
        Console.WriteLine("Subtração: " + resultado);

    }
    public static void AddSub()
    {
        int a = 10;
        int b = 2;

        a = a + 1;
        b = b - 1;
        Console.WriteLine("Incremento: " + a + " Decremento: " + b);

    }
}