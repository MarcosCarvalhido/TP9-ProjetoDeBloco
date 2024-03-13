
using TP9_ProjetoDeBloco;

public class Program
{
    public static void Main(string[] args)
    {
        Aluno marcos = new(00001, "Marcos");
        Aluno bruno = new(00002, "Bruno");
        Aluno ruan = new(00003, "Bruno");

        List<Aluno> lista = new List<Aluno>();

        lista.Add(marcos);
        lista.Add(bruno);
        lista.Add(ruan);

        Professor lp = new(0001, "LP");
        Disciplina projetoDeBloco = new(001, "Projeto De Bloco");
        Turma ADS = new(01, projetoDeBloco, lp, lista);

        Console.WriteLine(ADS.GerarPauta());

        Console.WriteLine("Numero de turmas: " + marcos.exibirTurmas().Count);

        Disciplina Net = new(002, ".Net");
        Turma ADS2 = new(01, projetoDeBloco, lp, lista);

        marcos.AddTurma(ADS);
        marcos.AddTurma(ADS2);

        Console.WriteLine("Numero de turmas: " + marcos.exibirTurmas().Count);

    }
}