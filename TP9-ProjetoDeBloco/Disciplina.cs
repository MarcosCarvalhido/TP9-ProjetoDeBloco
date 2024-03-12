using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9_ProjetoDeBloco
{
    internal class Disciplina
    {
        private int Codigo {  get; set; }
        private string Nome { get; set; }
        private Turma Turma { get; set; }

        Disciplina(int codigo, string nome, Turma turma)
        {
            Codigo = codigo;
            Nome = nome;
            Turma = turma;
        }

        public override string ToString()
        {
            return $"DISCIPLINA: {Nome}, Matricula: {Codigo}";
        }
    }
}
