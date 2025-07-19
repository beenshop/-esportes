using _esportes.Banco;
using _esportes.Modelos;

namespace _esportes.Menus;

class MenuSair : Menu
{
    public override void Executar(AlunoDAL alunoDAL, ProfessorDAL professorDAL, TurmaDAL turmaDAL)
    {
        base.Executar(alunoDAL, professorDAL, turmaDAL);
        Console.WriteLine("Pressione qualquer tecla para fechar...");
        Console.ReadKey();
    }
}
