using _esportes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _esportes.Banco;

internal class TurmaDAL
{
    private readonly maisEsportesContext context;

    public TurmaDAL(maisEsportesContext context)
    {
        this.context = context;
    }

    public IEnumerable<Turma> Listar()
    {
        return context.Turmas.ToList();
    }

    public void AdicionarTurma(Turma turma)
    {
        context.Turmas.Add(turma);
        context.SaveChanges();
    }

    public void AtualizarTurma(Turma turma)
    {
        context.Turmas.Update(turma);
        context.SaveChanges();
    }
    public void DeletarTurma(Turma turma)
    {
        context.Turmas.Remove(turma);
        context.SaveChanges();
    }
    public Turma? RecuperarPelaLetra(string letra)
    {
        return context.Turmas.FirstOrDefault(a => a.Modalidade.Equals(letra));
    }
}
