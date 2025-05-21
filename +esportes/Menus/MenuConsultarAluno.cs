using _esportes.Modelos;

namespace _esportes.Menus;

class MenuConsultarAluno : Menu
{
    public override void Executar(Dictionary<string, Turma> turmasRegistradas, Dictionary<string, Aluno> alunosRegistrados, Dictionary<string, Professor> professoresRegistrados) 
    {
        base.Executar(turmasRegistradas, alunosRegistrados, professoresRegistrados);
        ExibirTituloDaOpcao("Consulta de Alunos");
        Console.WriteLine("Digite o nome do aluno: ");
        string nome = Console.ReadLine()!;

        if (alunosRegistrados.ContainsKey(nome))
        {
        alunosRegistrados[nome].ExibirDetalhes();
        }
        else {
        Console.WriteLine("Aluno não encontrado!");
        }
    }
}