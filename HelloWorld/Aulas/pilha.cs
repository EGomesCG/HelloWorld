using System;
using System.Collections;

namespace HelloWorld.Aulas
{
    public class PilhaPrato
    {
        public static void Pilha()
        {
            ////Instânciando um objeto da queue - pilha
            Stack pilha = new Stack();
            //O conceito de pilha é o mesmo de uma pilha de pratos na pia,
            //a medida que vai sujando os prato vamos colocando o proximo em cima,
            //então, quando for tira será de cima para baixo 
            //Os metodo que podemos usar:

            pilha.Push("Prato 1");
            pilha.Push("Prato 2"); 
            pilha.Push("Prato 3");
            pilha.Push("Prato 4");
            pilha.Push("Prato 5");


            while (pilha.Count > 0)
            {
                //Conseguimos dar uma olhada no objeto de prato
                //var prato = pilha.Peek();
                //Tirando prato da pilha
                var prato = pilha.Pop();
                Console.WriteLine(prato);
            }

           
        }
    }
}