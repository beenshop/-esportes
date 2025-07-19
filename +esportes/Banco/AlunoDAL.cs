using _esportes.Modelos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _esportes.Banco;

internal class AlunoDAL
{
    private readonly maisEsportesContext context;

    public AlunoDAL(maisEsportesContext context)
    {
        this.context = context;
    }

    public IEnumerable<Aluno> Listar()
    {
        return context.Alunos.ToList();
    }
    
    public void AdicionarAluno(Aluno aluno)
    {
        context.Alunos.Add(aluno);
        context.SaveChanges();
    }

    public void AtualizarAlunos(Aluno aluno)
    {
        context.Alunos.Update(aluno);
        context.SaveChanges();
    }
    public void DeletarAluno(Aluno aluno)
    {
        context.Alunos.Remove(aluno);
        context.SaveChanges();
    }
        public Aluno? RecuperarPeloNome(string nome)
    {
        return context.Alunos.FirstOrDefault(a => a.Nome.Equals(nome));
    }
}
