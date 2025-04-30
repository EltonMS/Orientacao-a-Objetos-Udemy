using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOO.Exercicios_Udemy
{
    public class Pessoa
    {
        private string name { get; }
        private int idade { get; }
        private double altura { get; }

        public Pessoa(string name, int idade, double altura)
        {
            this.name = name;
            this.idade = idade;
            this.altura = altura;
        }

        public Pessoa(string name, int idade)
        {
            this.name = name;
            this.idade = idade;
        }
    }
}
