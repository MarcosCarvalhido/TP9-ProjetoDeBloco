using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9_ProjetoDeBloco
{
    public class Turma
    {
        private int Codigo { get; set; }
        private Disciplina Disciplina { get; set; }
        private Professor Professor { get; set; }
        private List<Aluno> Alunos { get; set; }

        public Turma(int codigo, Disciplina disciplina, Professor professor, List<Aluno> alunos)
        {
            Codigo = codigo;
            Disciplina = disciplina;
            Professor = professor;
            Alunos = alunos;
        }
        public void addAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }
        public bool AbrirTurma()
        {
            if (Alunos.Count >= 2 || Alunos.Count <= 10)
            {
                return true;
            }
            return false;
        }
        public string GerarPauta()
        {
            return $"CODIGO: {Codigo}, {Disciplina.ToString()}, {Professor.ToString()}"; 
        }
    }

}
