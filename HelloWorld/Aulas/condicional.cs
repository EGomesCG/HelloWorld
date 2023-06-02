using System;
class Condicional
{
    public static void comparacao()
    {
        int idade = 15;
        if (idade > 17)
        {
            Console.WriteLine("Autorizado!");
        }
        else if (idade > 2) { Console.WriteLine("Bebe suco"); }
        else { Console.WriteLine("Bebe leite"); }
    }
    public static void ternario()
    {
        int idade = 4;
        string resultado = idade > 60 ? "Aposentado" : "Trabalhando";
        Console.WriteLine(resultado);
    }
    public static void switch2()
    {
        int idade = 80;
        switch (idade)
        {            
            //O Case trabalha com valor exato
            //Todos os case acima de 60 terá o resultado igual de 60
            case 80:
            case 70:
            case 60: Console.WriteLine("Aposentado");
                break;
            case 10: Console.WriteLine("Criança");
                break;
            default: Console.WriteLine("Indefinido");
                break;

        }
    }
    public static void repeticaoForeach()
    {
        //Aqui ireimos definir uma coleção de inteiros, num vector
        //Que recebe = um novo objeto do tipo inteiro vetor 
        int[] colecao = new int[] { 1, 3, 50 };
        //Foreach tem uma variavel var e trabalha com uma coleção de coisas
        foreach (var item in colecao)
        {
            Console.WriteLine(item);            
        }
    }
    public static void repeticaoFor()
    {
        for(int i = 0; i <= 10; i++) 
        {
            Console.WriteLine(i);
        }
    }
    public static void repeticaoWhile()
    {
        int indice = 5;
        Console.WriteLine("While");
        while (indice > 0)
        {
            Console.WriteLine(indice);
            indice--;
        }
    }
    public static void repeticaoDoWhile()
    {
        int indice = 12;
        Console.WriteLine("Do While");
        //Faça alguma coisa e depois testa
        //Imprimi o indice, decrementa e verifica se é maior que 10,
        //Se sim, executa novamente, Se não sai da execução.
        do
        {
            Console.WriteLine(indice);
            indice--;
        }
        while (indice > 10);
    }
}