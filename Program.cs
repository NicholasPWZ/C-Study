using CS.Models;
using CStudy.Models;

Pessoa pessoa = new Pessoa();

pessoa.Nome = "Nicholas Costa";
pessoa.Birthday = "22-01-2002";
pessoa.Cpf = "03985852022";
pessoa.Idade = "22";

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Marcos Pato";
pessoa1.Birthday = "22-11-2000";
pessoa1.Cpf = "65687842133";
pessoa1.Idade = "27";

Curso curso = new Curso();
curso.Nome = "Wizard";
curso.Alunos = new List<Pessoa>();

curso.AdicionarAluno(pessoa);
curso.AdicionarAluno(pessoa1);
curso.ListarAluno();


