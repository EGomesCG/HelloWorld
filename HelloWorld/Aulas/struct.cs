//Struct não é para criar metodo e sim possuir atributos
//Como se fosse uma interface do typeScript
using System;

namespace HelloWorld
{
    struct MinhaData
    {
        public DateTime dataAtual;
    }
    struct Pessoa
    {
        //consegui acessar tenho que definir publico
        public int idade;
        public string nome;
        public float altura;
        //Áté dar para criar um método dentro de uma struct, porém,
        //a Microsoft recomenda criar uma classe e não uma struct para isto.
        public void MeuMetodo()
        { 
        }
    }
    //Struct serve para definir pequenas estrutura de dados
    //class teste : vetor2D
    //{
    //    //Struct não pode hedado, ou seja,
    //    //não pode ter filhos com as caracteristicas dele, já a class sim.

    //}
    struct vetor2D
    {
        public int x;
        public int y;
    }

}