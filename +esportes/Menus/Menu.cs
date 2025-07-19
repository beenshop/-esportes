using _esportes.Banco;
using _esportes.Modelos;

namespace _esportes.Menus;

class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    public virtual void Executar(AlunoDAL alunoDAL, ProfessorDAL professorDAL, TurmaDAL turmaDAL)
    {
        Console.Clear();
    }
}
