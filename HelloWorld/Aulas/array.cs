using System;
using System.Collections;

namespace HelloWorld.Aulas
{
    public class Lista
    {
        public static void ListaMercado()
        {
            ////Instânciando um objeto da queue - pilha
            ArrayList lista = new ArrayList();
            //O conceito de pilha é o mesmo de uma pilha de pratos na pia,
            //a medida que vai sujando os prato vamos colocando o proximo em cima,
            //então, quando for tira será de cima para baixo 
            //Os metodo que podemos usar:

            lista.Insert(0, "Item 1");
            lista.Insert(1, "Item 2");
            lista.Insert(2, "Item 3");
            lista.Insert(3, "Item 4");
            lista.Insert(4, "Item 5");
            lista.Insert(5, "Item 6");

            //Podemos inserir na posição que desejo um item
            lista.Insert(0, "Intruso");

            for (int i = 0; i < lista.Count; i++)
            {
                //Tirando prato da pilha
                var item = lista[i];
                //Para remover um item da lista
                lista.Remove(item);
                //Posso remover por index
//                lista.RemoveAt(0);
                Console.WriteLine(item);

            }

           
        }
    }
}