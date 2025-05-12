namespace _esportes.Modelos
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Turma { get; set; }

        public Aluno(string nome, int idade, string email, string endereco, string turma)
        {
            Nome = nome;
            Idade = idade;
            Email = email;
            Endereco = endereco;
            Turma = turma;
        }

        public void ExibirDetalhes()
        {
        
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("E-mail: " + Email);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Turma: " + Turma);
            Console.WriteLine("----------------------\n");
        
        }
    }
}
