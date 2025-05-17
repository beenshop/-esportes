using _esportes.Modelos;
using System.ComponentModel.Design;

Dictionary<string, Aluno> alunosRegistrados = new();
Aluno aluno1 = new Aluno("David", 15, "email1@email.com", "Rua ZZZ-XXX", "A");
Aluno aluno2 = new Aluno("Pedro", 14, "email2@email.com", "Rua ZZZ-XXX", "A");
Aluno aluno3 = new Aluno("Ricardo", 13, "email3@email.com", "Rua ZZZ-XXX", "A");
Aluno aluno4 = new Aluno("João", 12, "email4@email.com", "Rua ZZZ-XXX", "A");
Aluno aluno5 = new Aluno("Thaís", 12, "email5@email.com", "Rua ZZZ-XXX", "C");
Aluno aluno6 = new Aluno("Elena", 16, "email6@email.com", "Rua ZZZ-XXX", "C");
Aluno aluno7 = new Aluno("Samuel", 16, "email7@email.com", "Rua ZZZ-XXX", "B");
Aluno aluno8 = new Aluno("Joaquim", 14, "email8@email.com", "Rua ZZZ-XXX", "B");
Aluno aluno9 = new Aluno("Clara", 12, "email9@email.com", "Rua ZZZ-XXX", "B");

alunosRegistrados.Add(aluno1.Nome, aluno1);
alunosRegistrados.Add(aluno2.Nome, aluno2);
alunosRegistrados.Add(aluno3.Nome, aluno3);
alunosRegistrados.Add(aluno4.Nome, aluno4);
alunosRegistrados.Add(aluno5.Nome, aluno5);
alunosRegistrados.Add(aluno6.Nome, aluno6);
alunosRegistrados.Add(aluno7.Nome, aluno7);
alunosRegistrados.Add(aluno8.Nome, aluno8);
alunosRegistrados.Add(aluno9.Nome, aluno9);



Dictionary<string, Professor> professoresRegistrados = new();
Professor professor1 = new Professor("César", 35, "professor@email.com", "Rua XXX-ZZZ", "A e B");
Professor professor2 = new Professor("Fernanda", 28, "professor2@email.com", "Rua XXX-ZZZ", "C");

professoresRegistrados.Add(professor1.Nome, professor1);
professoresRegistrados.Add(professor2.Nome, professor2);


Dictionary<string, Turma> turmasRegistradas = new();
Turma turma1 = new Turma("A", "Futebol", "César", "Manhã");
Turma turma2 = new Turma("B", "Basquete", "César", "Tarde");
Turma turma3 = new Turma("C", "Vôlei", "Fernanda", "Noite");

turmasRegistradas.Add(turma1.ID, turma1);
turmasRegistradas.Add(turma2.ID, turma2);
turmasRegistradas.Add(turma3.ID, turma3);


turma1.AlunosRegistrados.Add(aluno1);
turma1.AlunosRegistrados.Add(aluno2);
turma1.AlunosRegistrados.Add(aluno3);

turma2.AlunosRegistrados.Add(aluno7);
turma2.AlunosRegistrados.Add(aluno8);
turma2.AlunosRegistrados.Add(aluno9);

turma3.AlunosRegistrados.Add(aluno4);
turma3.AlunosRegistrados.Add(aluno5);
turma3.AlunosRegistrados.Add(aluno6);


ExibirOpcoesDoMenu();

void CadastrarAluno()
{
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
    } else
    {
        Console.WriteLine("Turma não encontrada!");
        return;
    }

    Aluno aluno = new Aluno(nome, idade, email, endereco, turma);

    foreach (Turma t in turmasRegistradas.Values)
    {
    if ( t.ID == turma )
        {
            t.AlunosRegistrados.Add(aluno);
        }
    }


    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void CadastrarProfessor()
{
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
    professoresRegistrados.Add(nome, professor);

    Console.WriteLine("Professor adicionado com sucesso.");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void CadastrarTurma()
{
    Console.WriteLine("Digite o ID da turma: ");
    string id = Console.ReadLine()!;
    if (turmasRegistradas.ContainsKey(id)) {
        Console.WriteLine("Já existe uma turma com essa ID!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else {
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
    ExibirOpcoesDoMenu();
    }

}

void ConsultarAluno()
    {
        Console.WriteLine("Digite o nome do aluno: ");
        string nome = Console.ReadLine()!;

        if (alunosRegistrados.ContainsKey(nome))
        {
            alunosRegistrados[nome].ExibirDetalhes();
        }
        else
        {
            Console.WriteLine("Aluno não encontrado!");
            ExibirOpcoesDoMenu();
        }
        ExibirOpcoesDoMenu();
    }

void ConsultarProfessor()
    {
        Console.WriteLine("Digite o nome do professor: ");
        string nome = Console.ReadLine()!;

        if (professoresRegistrados.ContainsKey(nome))
        {
            professoresRegistrados[nome].ExibirDetalhes();
        }
        else
        {
            Console.WriteLine("Professor não encontrado!");
            ExibirOpcoesDoMenu();
        }
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

void ConsultarTurmas()
{
    Console.WriteLine("Digite o ID da turma: ");
    string ID = Console.ReadLine()!;

    if (turmasRegistradas.ContainsKey(ID))
    {   
        foreach (Turma turma in turmasRegistradas.Values)
        {
            if (ID == turma.ID)
            {
            Console.WriteLine($"Essa turma tem {turma.AlunosRegistrados.Count} alunos.\n");
            turma.ExibirDetalhes();
            foreach (Aluno aluno in turma.AlunosRegistrados)
            {
            Console.WriteLine($"{aluno.Nome}");
            }

            }
        }

    } else {
        Console.WriteLine("Turma não encontrada!");
        ExibirOpcoesDoMenu();
    }
    

    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void Sair()
{
    Console.WriteLine("Pressione qualquer tecla para fechar...");
    Console.ReadKey();
}

void ExibirOpcoesDoMenu()
    {
        Console.WriteLine("Selecione uma opção:");
        Console.WriteLine("1 - Cadastrar Aluno");
        Console.WriteLine("2 - Cadastrar Professor");
        Console.WriteLine("3 - Cadastrar Turma");
        Console.WriteLine("4 - Consulta de Aluno");
        Console.WriteLine("5 - Consulta de Professor");
        Console.WriteLine("6 - Consulta de Turmas");
        Console.WriteLine("7 - Sair\n");

        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                CadastrarAluno();
                break;
            case 2:
                CadastrarProfessor();
                break;
            case 3:
                CadastrarTurma();
                break;
            case 4:
                ConsultarAluno();
                break;
            case 5:
                ConsultarProfessor();
                break;
            case 6:
                ConsultarTurmas();
            break;
            case 7:
                Sair();
                break;
            default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}


