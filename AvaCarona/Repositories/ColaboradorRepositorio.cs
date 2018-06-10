using AvaCarona.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaCarona.Repositories
{
  public class ColaboradorRepositorio
  {
    public List<Colaborador> Colaboradores { get; set; }

    public void Add(Colaborador colaborador)
    {
      Colaboradores.Add(colaborador);
    }

    public Colaborador Get(string eid)
    {
      return 
    }

  }
}
