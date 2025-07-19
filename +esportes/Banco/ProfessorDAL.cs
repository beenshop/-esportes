using _esportes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _esportes.Banco;

internal class ProfessorDAL
{
    private readonly maisEsportesContext context;

    public ProfessorDAL(maisEsportesContext context)
    {
        this.context = context;
    }

    public IEnumerable<Professor> Listar()
    {
        return context.Professores.ToList();
    }

    public void AdicionarProfessor(Professor professor)
    {
        context.Professores.Add(professor);
        context.SaveChanges();
    }

    public void AtualizarProfessor(Professor professor)
    {
        context.Professores.Update(professor);
        context.SaveChanges();
    }
    public void DeletarProfessor(Professor professor)
    {
        context.Professores.Remove(professor);
        context.SaveChanges();
    }
    public Professor? RecuperarPeloNome(string nome)
    {
        return context.Professores.FirstOrDefault(a => a.Nome.Equals(nome));
    }
}
