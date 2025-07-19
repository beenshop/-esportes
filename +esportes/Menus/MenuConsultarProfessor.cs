using _esportes.Banco;
using _esportes.Modelos;

namespace _esportes.Menus;

class MenuConsultarProfessor : Menu
{
    public override void Executar(AlunoDAL alunoDAL, ProfessorDAL professorDAL, TurmaDAL turmaDAL)
    {
        base.Executar(alunoDAL, professorDAL, turmaDAL);
        ExibirTituloDaOpcao("Consulta de Professores");
        Console.WriteLine("Digite o nome do professor: ");
        string nome = Console.ReadLine()!;
        var professorRecuperado = professorDAL.RecuperarPeloNome(nome);
        if (professorRecuperado is not null)
        {
            professorRecuperado.ExibirDetalhes();
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
