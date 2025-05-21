using _esportes.Modelos;
using System;

namespace _esportes.Menus;

class MenuCadastrarTurma : Menu
{
    public override void Executar(Dictionary<string, Turma> turmasRegistradas, Dictionary<string, Aluno> alunosRegistrados, Dictionary<string, Professor> professoresRegistrados)
    {
        base.Executar(turmasRegistradas, alunosRegistrados, professoresRegistrados);
        ExibirTituloDaOpcao("Cadastro de Turmas");

        Console.WriteLine("Digite o ID da turma: ");
        string id = Console.ReadLine()!;
        if (turmasRegistradas.ContainsKey(id))
        {
            Console.WriteLine("Já existe uma turma com essa ID!");
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

            Turma turma = new Turma(id, modalidade, professor, horario);
            turmasRegistradas.Add(id, turma);

            Console.WriteLine("Turma registrada com sucesso.");
            Thread.Sleep(4000);
            Console.Clear();
        }
    }
}
