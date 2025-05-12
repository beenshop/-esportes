namespace _esportes.Modelos;

class Turma
{
    public string ID { get; set; }
    public string Modalidade { get; set; }
    public string Professor { get; set; }
    public string Horario { get; set; }
    
    public Turma(string id, string modalidade, string professor, string horario)
    {
        ID = id;
        Modalidade = modalidade;
        Professor = professor;
        Horario = horario;

    }

    public void ExibirDetalhes()
    {

        Console.WriteLine("Turma: " + ID);
        Console.WriteLine("Modalidade: " + Modalidade);
        Console.WriteLine("Professor: " + Professor);
        Console.WriteLine("Horário: " + Horario);
        Console.WriteLine("----------------------\n");
        

    }
}