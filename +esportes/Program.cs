using _esportes.Menus;
using _esportes.Modelos;

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

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuCadastrarAluno());
opcoes.Add(2, new MenuCadastrarProfessor());
opcoes.Add(3, new MenuCadastrarTurma());
opcoes.Add(4, new MenuConsultarAluno());
opcoes.Add(5, new MenuConsultarProfessor());
opcoes.Add(6, new MenuConsultarTurmas());
opcoes.Add(7, new MenuSair());

ExibirOpcoesDoMenu();

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

    Console.Write("Digite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = Convert.ToInt32(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica) && opcaoEscolhidaNumerica != 7)
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(turmasRegistradas, alunosRegistrados, professoresRegistrados);
        ExibirOpcoesDoMenu();
    }
    else if (opcaoEscolhidaNumerica == 7)
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(turmasRegistradas, alunosRegistrados, professoresRegistrados);
    }
    else
    {
        Console.WriteLine("Opção inválida.");
    }
}

//switch (opcaoEscolhidaNumerica)
//{
//    case 1:
//        MenuCadastrarAluno menu1 = new();
//        menu1.Executar(turmasRegistradas, alunosRegistrados);
//        ExibirOpcoesDoMenu();
//        break;
//    case 2:
//        MenuCadastrarProfessor menu2 = new();
//        menu2.Executar(professoresRegistrados);
//        ExibirOpcoesDoMenu();
//        break;
//    case 3:
//        MenuCadastrarTurma menu3 = new();
//        menu3.Executar(turmasRegistradas);
//        ExibirOpcoesDoMenu();
//        break;
//    case 4:
//        MenuConsultarAluno menu4 = new();
//        menu4.Executar(alunosRegistrados);
//        ExibirOpcoesDoMenu();
//        break;
//    case 5:
//        MenuConsultarProfessor menu5 = new();
//        menu5.Executar(professoresRegistrados);
//        ExibirOpcoesDoMenu();
//        break;
//    case 6:
//        MenuConsultarTurmas menu6 = new();
//        menu6.Executar(turmasRegistradas);
//        ExibirOpcoesDoMenu();
//        break;
//    case 7:
//        MenuSair menu7 = new();
//        menu7.Executar();
//        break;
//    default:
//        Console.WriteLine("Opção inválida.");
//        break;
//}



