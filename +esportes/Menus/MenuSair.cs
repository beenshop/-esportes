using _esportes.Modelos;

namespace _esportes.Menus;

class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Turma> turmasRegistradas, Dictionary<string, Aluno> alunosRegistrados, Dictionary<string, Professor> professoresRegistrados)
    {
        base.Executar(turmasRegistradas, alunosRegistrados, professoresRegistrados);
        Console.WriteLine("Pressione qualquer tecla para fechar...");
        Console.ReadKey();
    }
}
