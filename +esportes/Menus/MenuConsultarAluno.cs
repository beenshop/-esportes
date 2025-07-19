using _esportes.Banco;
using _esportes.Modelos;

namespace _esportes.Menus;

class MenuConsultarAluno : Menu
{
    public override void Executar(AlunoDAL alunoDAL, ProfessorDAL professorDAL, TurmaDAL turmaDAL)
    {
        base.Executar(alunoDAL, professorDAL, turmaDAL);
        ExibirTituloDaOpcao("Consulta de Alunos");
        Console.WriteLine("Digite o nome do aluno: ");
        string nome = Console.ReadLine()!;
        var AlunoRecuperado = alunoDAL.RecuperarPeloNome(nome);
        if (AlunoRecuperado is not null)
        {
            Console.WriteLine(" ");
            AlunoRecuperado.ExibirDetalhes();
        }
        else {
        Console.WriteLine("Aluno não encontrado!");
        }
    }
}