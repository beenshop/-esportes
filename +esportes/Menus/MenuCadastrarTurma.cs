using _esportes.Banco;
using _esportes.Modelos;
using System;

namespace _esportes.Menus;

class MenuCadastrarTurma : Menu
{
    public override void Executar(AlunoDAL alunoDAL, ProfessorDAL professorDAL, TurmaDAL turmaDAL)
    {
        base.Executar(alunoDAL, professorDAL, turmaDAL);
        ExibirTituloDaOpcao("Cadastro de Turmas");

        Console.WriteLine("Digite o ID da turma: ");
        string letra = Console.ReadLine()!;
        var turmaRecuperada = turmaDAL.RecuperarPelaLetra(letra);
        if (turmaRecuperada is not null)
        {
            Console.WriteLine("Já existe uma turma registrada com essa Letra!");
            Thread.Sleep(4000);
            Console.Clear();
            MenuCadastrarTurma menu = new();
        }
        else
        {
            Console.WriteLine("Digite a modalidade da turma: ");
            string modalidade = Console.ReadLine()!;

            Console.WriteLine("Digite o nome do professor: ");
            string professor = Console.ReadLine()!;

            Console.WriteLine("Digite o horário da aula: ");
            string horario = Console.ReadLine()!;

            Turma turma = new Turma(modalidade, professor, horario, letra);
            turmaDAL.AdicionarTurma(turma);

            Console.WriteLine("Turma registrada com sucesso.");
            Thread.Sleep(4000);
            Console.Clear();
        }
    }
}
