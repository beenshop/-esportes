using _esportes.Banco;
using _esportes.Modelos;

namespace _esportes.Menus;

class MenuCadastrarProfessor : Menu
{
    public override void Executar(AlunoDAL alunoDAL, ProfessorDAL professorDAL, TurmaDAL turmaDAL)
    {
        base.Executar(alunoDAL, professorDAL, turmaDAL);
        ExibirTituloDaOpcao("Cadastro de Professores");

        Console.WriteLine("Digite o nome do professor: ");
        string nome = Console.ReadLine()!;

        Console.WriteLine("Digite a idade do professor: ");
        int idade = Convert.ToInt32(Console.ReadLine())!;

        Console.WriteLine("Digite o e-mail do professor: ");
        string email = Console.ReadLine()!;

        Console.WriteLine("Digite o endereço do professor: ");
        string endereco = Console.ReadLine()!;

        Console.WriteLine("Digite as turma que o professor irá lecionar: ");
        string turma = Console.ReadLine()!;

        Professor professor = new Professor(nome, idade, email, endereco, turma);
        professorDAL.AdicionarProfessor(professor);

        Console.WriteLine("Professor adicionado com sucesso.");
        Thread.Sleep(4000);
        Console.Clear();
    }
}
