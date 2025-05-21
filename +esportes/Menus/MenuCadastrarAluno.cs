using _esportes.Modelos;

namespace _esportes.Menus;

class MenuCadastrarAluno : Menu
{
    public override void Executar(Dictionary<string, Turma> turmasRegistradas, Dictionary<string, Aluno> alunosRegistrados, Dictionary<string, Professor> professoresRegistrados)
    {
        base.Executar(turmasRegistradas, alunosRegistrados, professoresRegistrados);
        ExibirTituloDaOpcao("Cadastro de Alunos");
        
        Console.WriteLine("Digite o nome do aluno: ");
        string nome = Console.ReadLine()!;

        Console.WriteLine("Digite a idade do aluno: ");
        int idade = Convert.ToInt32(Console.ReadLine())!;

        Console.WriteLine("Digite o e-mail do aluno: ");
        string email = Console.ReadLine()!;

        Console.WriteLine("Digite o endereço do aluno: ");
        string endereco = Console.ReadLine()!;

        Console.WriteLine("Digite a turma que o aluno irá entrar: ");
        string turma = Console.ReadLine()!;
        if (turmasRegistradas.ContainsKey(turma))
        {
            Console.WriteLine("Aluno adicionado com sucesso.");
        }
        else
        {
            Console.WriteLine("Turma não encontrada!");
            return;
        }

        Aluno aluno = new Aluno(nome, idade, email, endereco, turma);

        foreach (Turma t in turmasRegistradas.Values)
        {
            if (t.ID == turma)
            {
                t.AlunosRegistrados.Add(aluno);
            }
        }


        Thread.Sleep(4000);
        Console.Clear();
        }
        }


