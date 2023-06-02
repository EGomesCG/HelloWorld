using System;

namespace HelloWorld.Classe
{
    //Encapsulamento das propriedades
    //1º Questão de segurança, as propriedades da classe serão privadas, somente a classe terá acessa a informação da propriedade
    //Então, para ter acesso as dados da propriedade privada, tenhos que criar os metodos get e set
    public class encapsulamento
    {
        public int id;
        //Fields da propriedade privada, cria-se com mesmo nome porem com a 1ª letra maíuscula e declaramos os metodos
        private string valor;
        //Get irá retorna o valor e o Set atribuir o valor nessa propriedade
        public string Valor { get { return valor; } set {  valor = value; } }

        //Posso tranformar minha propriedade em privado, com botão direito 
        //Clico no nome da propriedade e clico em refact, encapsular fields e automaticamente é criado o fields da minha propriedade 
        private string produto;
        public string Produto { get => produto; set => produto = value; }

        //Posso colocar regras de segurança no momento de atribuir um valor na minha propriedade
        //Por exemplo idade, sabemos que não existe idade menor que 0.
        private int idade;
        public int Idade 
        {
            get { return idade;  }
            //Só irá mudar/cetar o valor se for maior ou igual a 0 
            set
            {
                if(idade >= 0)
                    idade = value; 
            }
        }
    }
}
