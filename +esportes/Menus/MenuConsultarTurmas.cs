using _esportes.Modelos;

namespace _esportes.Menus;

class MenuConsultarTurmas : Menu
{
    public override void Executar(Dictionary<string, Turma> turmasRegistradas, Dictionary<string, Aluno> alunosRegistrados, Dictionary<string, Professor> professoresRegistrados)
    {
        base.Executar(turmasRegistradas, alunosRegistrados, professoresRegistrados);
        ExibirTituloDaOpcao("Consulta de Turmas");
        Console.WriteLine("Digite o ID da turma: ");
        string ID = Console.ReadLine()!;

        if (turmasRegistradas.ContainsKey(ID))
        {   
        foreach (Turma turma in turmasRegistradas.Values)
        {
            if (ID == turma.ID)
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
