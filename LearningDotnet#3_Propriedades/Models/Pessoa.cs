using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningDotnet.Models
{
    public class Pessoa
    {
        public Pessoa() {}

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        
        //Private Properties
        private string _nome;
        private int _idade;

        //Public Properties
        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A Idade nao pode ser menor que 0");
                }

                _idade = value;
            }
        }

        public string Nome
        {
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O Nome nao pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        //Methods
        public void Apresentar()
        {
            Console.WriteLine($"Bom Dia, Meu nome é {NomeCompleto} e tenho {Idade} anos");
        }
    }
}