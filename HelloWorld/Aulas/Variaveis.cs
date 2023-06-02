using System;

class SVariaveis
{

    public static void Variaveis()
    {
        //Variaveis, são:
        //Int(inteiro e negativo), Float(Numero decimal) e Double
        //Bool - true e false
        //String - "" / texto
        //Char - '' / caracter ('a' um unico caracter)
        int segundaGuerraMundial = 1942;
        string corFavorita = "Preto";
        DateTime dataNascimento = DateTime.Now;//Data
        float velocidadeF1 = 291.48f;//O f no final indica que este valor é float
        bool segundaGuerraMundial1 = true;
        decimal salario = 1000;
        var texto = "Olá mundo";
        char sexo = 'f';//Char aceita apenas um caracter e são aspas simples
        //É declarado e nunca mais pode mudar o valor desta variavel
        //const float valorfixo = 3.145565656f;
        string nome = "Érica";
        string sobrenome = "Gomes";
        string retornado = Metodo.comRetorno();
        ////////////////////////////////////////////////
        //Para obter o valor passado e modificado pelo o metodo.
        //Para isto iremos utilizar referência.
        Parametro.SomarRef10(ref segundaGuerraMundial);
        Console.WriteLine("Um decada após a SGM: " + segundaGuerraMundial);
        //Quando passo o valor por referencia 
        Parametro.Somar10(10);
        ///Passando parametro
        Parametro.ImprimirValor(3, "Trindade");
        Console.WriteLine(retornado);
        Metodo.semRetorno();
        Operadores.Comparador();
        Condicional.repeticaoDoWhile();
        Condicional.repeticaoWhile();
        Condicional.repeticaoFor();
        Condicional.repeticaoForeach();
        Condicional.switch2();
        Condicional.ternario();
        Condicional.comparacao();
        contas.multiplicacao();
        contas.divisao();
        contas.subtracao();
        contas.soma();
        contas.AddSub();
        //Tratando ou formatando string
        Console.WriteLine(string.Format("{0} {1}", nome, sobrenome));
        Console.WriteLine(segundaGuerraMundial);
        Console.WriteLine(dataNascimento);
        Console.WriteLine(corFavorita);
        Console.WriteLine(velocidadeF1);
        Console.WriteLine(segundaGuerraMundial1);
        Console.WriteLine(texto);
        Console.WriteLine(salario);
        Console.WriteLine(sexo);
        Console.WriteLine(texto);
    }

}
