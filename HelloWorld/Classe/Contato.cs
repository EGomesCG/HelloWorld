using HelloWorld.Aulas;
using System;
using System.Globalization;

namespace HelloWorld //
{
    public class Contato
    {
        //Classe tem propriedades e metodos
        //Para ter acesso as propriedades da classe preciso declarar como:
        //public, tipo e o nome da propriedade
        public string nome;
        public string sobrenome;
        public int idade;
        public DateTime dataNascimento;

        //Para usar a classe em outras partes do sistema preciso 
        //declara aqui o construtor da mesma.
        //Que terá o mesmo nome da classe
        //Aqui podemos definir os valores setados das prorpriedades da classe.
        public Contato()
        {
            
        }
        //Aqui estamos utilizando o enum SEXO de char agora 
        private Sexo sexo;

        public Sexo Sexo { get => sexo; set => sexo = value; }

        //Metodo - comportamento dessa classe.
        public void falar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
