using System;

namespace AvaCarona.Domain
{
  public class Colaborador
  {
    public string Nome { get; set; }
    public string Eid { get; set; }
    public int Pid { get; set; }

    public Colaborador(string nome, string eid, int pid)
    {
      Nome = nome;
      ValidacaoEid(eid);
      Pid = pid;
    }

    public bool ValidacaoEid(string eid)
    {
      if(eid.Length > 3 && eid.Length < 20)
      {
        Eid = eid;
        return true;
      }

      return false;
    }
  }
}
