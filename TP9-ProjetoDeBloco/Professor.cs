using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9_ProjetoDeBloco
{
    public class Professor
    {
        private int Matricula {  get; set; }
        private string Nome {  get; set; }
        private Turma Turma { get; set; }

        public Professor(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"PROFESOR: {Nome}, Matricula: {Matricula}";
        }
    }
}
