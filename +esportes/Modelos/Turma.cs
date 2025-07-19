namespace _esportes.Modelos;

class Turma
{
    public int Id { get; set; }
    public string Modalidade { get; set; }
    public string Professor { get; set; }
    public string Horario { get; set; }
    public string Letra { get; set; }
    
    public Turma(string modalidade, string professor, string horario, string letra)
    {
        Modalidade = modalidade;
        Professor = professor;
        Horario = horario;
        Letra = letra;
    }

    public List<Aluno> AlunosRegistrados = new();

    public void ExibirDetalhes()
    {
        Console.WriteLine("Turma: " + Letra);
        Console.WriteLine("Modalidade: " + Modalidade);
        Console.WriteLine("Professor: " + Professor);
        Console.WriteLine("Horário: " + Horario);
        Console.WriteLine("----------------------\n");
    }
}