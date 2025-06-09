using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningDotnet.Models
{
    public class Curso
    {
        //Public Properties
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public int ObterContagemDeAlunos()
        {
            return Alunos.Count;
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Lista de Alunos do Curso {Nome}");
            for (int i = 0; i < Alunos.Count; i++)
            {

                Console.WriteLine($"Aluno N° {i + 1}: {Alunos[i].NomeCompleto}");
            }
        }
    }
}