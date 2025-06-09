using LearningDotnet.Models;

Pessoa me = new Pessoa(nome: "John", sobrenome: "Santos");
me.Idade = 23;
me.Apresentar();

Pessoa you = new Pessoa("Eduardo", "Silva");
you.Idade = 21;
you.Apresentar();

Curso curso = new Curso();
curso.Nome = "Curso de Ingles";
curso.Alunos = new List<Pessoa>();

curso.AdicionarAluno(me);
curso.AdicionarAluno(you);
curso.ListarAlunos();
