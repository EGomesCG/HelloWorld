using HelloWorld.Aulas;
using System;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {      
        internal static async Task Main(string[] args)
        {
            ///Lista
            Lista.ListaMercado();
            //Pilha de prato
            PilhaPrato.Pilha();
            ////Fila
            FilaBanco.Fila();

            //O objeto é a representação da classe, então, para usar a classe
            //Precisamos cria o objeto dessa classe.
            //Quando criamos este obj. estamos reservando uma área de memória 
            Contato contato = new Contato();

            //Aqui estamos preenchendo essa área da memória
            contato.nome = "João";
            contato.sobrenome = "Gomes";
            contato.idade = 18;
            contato.dataNascimento = DateTime.Now;
            //Usando uma variavel privada que possui enum
            contato.Sexo = Sexo.Masculino;
            contato.falar("Olá, sou o " + contato.nome);

            //Usando a formatação string
            contato.falar(string.Format("Olá, sou o {0} {1}, tenho {2} anos (FORMATAÇÃO DE STRING)", contato.nome, contato.sobrenome, contato.idade));

            //Criando uma pessoa da struct
            //Struct não recebe null, ou seja, não pode passar o valor null para struct
            Pessoa erica = new Pessoa();
            erica.altura = 1.65f;
            erica.idade = 38;
            erica.nome = "Érica Gonçalves";

            Console.WriteLine("Nome:" + erica.nome);
            Console.WriteLine("Idade:" + erica.idade);
            Console.WriteLine("Altura:" + erica.altura);
            //////////////////////////////////////////////////////////
            //Variaveis, são:
            //Int(inteiro e negativo), Float(Numero decimal) e Double
            //Bool - true e false
            //String - "" / texto
            //Char - '' / caracter ('a' um unico caracter)
            int segundaGuerraMundial = 1942;
            string corFavorita = "Preto";
            float velocidadeF1 = 291.48f;//O f no final indica que este valor é float
            bool segundaGuerraMundial1 = true;
            var texto = "Olá mundo";
            const float valorfixo = 3.145565656f;//É declarado e nunca mais pode mudar o valor desta variavel

            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerraMundial1);
            Console.WriteLine(texto);
            Console.WriteLine(valorfixo);

            velocidadeF1 = 24.5f;

            Console.WriteLine(velocidadeF1);

            Console.WriteLine("Escreva seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Seu nome é:");
            Console.WriteLine(nome);
            int numqq = 20 + 20 - 80;
            int numMult = 10 * 90;
            float numDiv = 5.0f / 2;

            Console.WriteLine(numqq);
            Console.WriteLine(numMult);
            Console.WriteLine(numDiv);
            ////////////////////////////////////////////////////////////
            //Café sincrono => Bloqueante
            Requisicoes.misturarBolo();
            Requisicoes.assarForno();
            Requisicoes.servirBolo();

            //Async => Não-bloqueante
            Task.Run<Cafe>(() => fazerCafe()).ContinueWith((result) => 
            {
                Console.WriteLine(result.Result.nome);
            });
            Task.Run<Ovo>(() => fazerOvos()).ContinueWith((result) => 
            {
                Console.WriteLine(result.Result.nome);
            });
            Task.Run(async () => fazerTorrada());

            SVariaveis.Variaveis();
            
            Console.ReadLine();
        }

        //Metodo asyncrono que recebe como parametro o tipo de classe <Cafe> que também pode recebe um (atributo)
        static async Task<Cafe> fazerCafe()
        {
            Console.WriteLine("Colocando café no fogo!");
            Task.Delay(TimeSpan.FromSeconds(10)).Wait();
            Console.WriteLine("Café feito!");
            return new Cafe();
        }
        static async Task fazerTorrada()
        {
            Console.WriteLine("Colocando torrada na torradeira!");
            Task.Delay(TimeSpan.FromSeconds(2)).Wait();
            Console.WriteLine("Torrada feita!");
        }
        static async Task<Ovo> fazerOvos()
        {
            Console.WriteLine("Misturando ingredientes da omelete!");
            //Dando um tempo antes de enviar a resposta
            Task.Delay(TimeSpan.FromSeconds(6)).Wait();
            Console.WriteLine("Omelete feita!");
            return new Ovo();
        }
        class Cafe
        {
            public string nome = "Café Pilão";
        }
        class Ovo
        {
            public string nome = "Ovos brancos";
        }
    }
}
