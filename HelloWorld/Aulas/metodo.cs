using System;
class Metodo
{
    //Metodo tem um objetivo que é executar uma tarefa especifica,
    //o ideal que seja apenas uma. 
    //Metodo/Função
    //quando não tem retorno usamos a palavra reservada void para declara-lo
    public static void semRetorno()
    {
        Console.WriteLine("Exibir mensagem!");
    }
    public static string comRetorno()
    {
        string text = "Com retorno";
        return text;
    }
}