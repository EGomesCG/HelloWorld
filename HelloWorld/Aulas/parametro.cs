using System;
class Parametro
{
    //Este metodo recebe dois parametros, mas, não retorna nada
    public static void ImprimirValor(int valor, string mensagem)
    {
        Console.WriteLine(valor + " " + mensagem);
    }
    public static void Somar10(int valor)
    {
        valor += 10;
        Console.WriteLine(valor);
    }
    public static void SomarRef10(ref int valor)
    {
        valor += 10;
        Console.WriteLine(valor);
    }
}