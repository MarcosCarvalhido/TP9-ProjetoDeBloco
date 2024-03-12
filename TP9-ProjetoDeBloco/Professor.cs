using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9_ProjetoDeBloco
{
    internal class Professor
    {
        private int Matricula {  get; set; }
        private string Nome {  get; set; }
        private Turma Turma { get; set; }

        Professor(int matricula, string nome, Turma turma)
        {
            Matricula = matricula;
            Nome = nome;
            Turma = turma;
        }

        public override string ToString()
        {
            return $"PROFESOR: {Nome}, Matricula: {Matricula}";
        }
    }
}
