using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9_ProjetoDeBloco
{
    internal class Aluno
    {
        private int Matricula { get; set; }
        private string Nome { get; set; }
        private List<Turma> turmas { get; set;}

        Aluno(int matricula, string nome, List<Turma> turmas)
        {
            Matricula = matricula;
            Nome = nome;
            this.turmas = turmas;
        }

        public void AddTurma(Turma turma)
        {
            turmas.Add(turma);
        }
        public  List<Turma> exibirTurmas()
        {
            return turmas;
        }
        public override string ToString()
        {
            return $"ALUNO: {Nome}, Matricula: {Matricula}";
        }
    }
}
