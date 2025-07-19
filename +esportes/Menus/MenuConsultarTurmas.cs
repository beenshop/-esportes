using _esportes.Banco;
using _esportes.Modelos;

namespace _esportes.Menus;

class MenuConsultarTurmas : Menu
{
    public override void Executar(AlunoDAL alunoDAL, ProfessorDAL professorDAL, TurmaDAL turmaDAL)
    {
        base.Executar(alunoDAL, professorDAL, turmaDAL);
        ExibirTituloDaOpcao("Consulta de Turmas");
        Console.WriteLine("Digite a letra da turma: ");
        string letra = Console.ReadLine()!;
        var turmaRecuperada = turmaDAL.RecuperarPelaLetra(letra);

        if (turmaRecuperada is not null)
        {
            turmaRecuperada.ExibirDetalhes();
            
            foreach (Turma turma in turmasRegistradas.Values)
            {
                if (ID == turma.Id)
                {
                    Console.WriteLine($"Essa turma tem {turma.AlunosRegistrados.Count} alunos.\n");
                    turma.ExibirDetalhes();
                    foreach (Aluno aluno in turma.AlunosRegistrados)
                    {
                        Console.WriteLine($"{aluno.Nome}");
                    }

                }
            }

        } else
        {
        Console.WriteLine("Turma não encontrada!");
        MenuConsultarTurmas menu = new();
        }

        Thread.Sleep(4000);
        Console.Clear();
    }
}
