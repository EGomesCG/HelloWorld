using System;
using System.Threading.Tasks;

namespace HelloWorld.Aulas
{
    class Requisicoes
    {
        public static void misturarBolo()
        {
            Console.WriteLine("Massa de bolo feita!");
        }
        public static void assarForno()
        {
            Console.WriteLine("Bolo assado!");
        }
        public static void servirBolo()
        {
            Console.WriteLine("Bolo servido!");
        }
        //Metodo asyncrono que recebe como parametro o tipo de classe <Cafe> que também pode recebe um (atributo)
        public static async Task<Cafe> FazerCha()
        {
            Console.WriteLine("Colocando chá no fogo!");
            Task.Delay(TimeSpan.FromSeconds(10)).Wait();
            Console.WriteLine("Chá feito!");
            return new Cafe();
        }
        public class Cafe
        {
            public string nome = "Camomila";
        }

    }
}
