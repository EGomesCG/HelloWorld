using System;
using System.Collections;

namespace HelloWorld.Aulas
{
    public class FilaBanco
    {
        public static void Fila()
        {
            //Instânciando um objeto da queue - fila
            Queue fila = new Queue();

            //Queue pode ser uma coleção de uma coisa que faz sentido
            //Nosso objeto fila tem um metodo Enqueue
            fila.Enqueue("Maria Aparecida");
            fila.Enqueue("Pedro Henrique");
            fila.Enqueue("Bernando Cruz");
            fila.Enqueue("Ana Julia");

            while (fila.Count > 0)
            {
                //Conseguimos dar uma olhada na fila
                //var nome = fila.Peek();
                //Tirando da fila
                var nome = fila.Dequeue();
                Console.WriteLine(nome);
            }

           
        }
    }
}