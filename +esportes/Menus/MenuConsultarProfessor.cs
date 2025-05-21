using _esportes.Modelos;

namespace _esportes.Menus;

class MenuConsultarProfessor : Menu
{
    public override void Executar(Dictionary<string, Turma> turmasRegistradas, Dictionary<string, Aluno> alunosRegistrados, Dictionary<string, Professor> professoresRegistrados)
    {
        base.Executar(turmasRegistradas, alunosRegistrados, professoresRegistrados);
        ExibirTituloDaOpcao("Consulta de Professores");
        Console.WriteLine("Digite o nome do professor: ");
        string nome = Console.ReadLine()!;

        if (professoresRegistrados.ContainsKey(nome))
        {
            professoresRegistrados[nome].ExibirDetalhes();
}
        else
        {
            Console.WriteLine("Professor não encontrado!");
            MenuConsultarAluno menu = new();
        }
        Thread.Sleep(4000);
        Console.Clear();

    }
}
