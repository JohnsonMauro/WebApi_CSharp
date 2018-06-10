using System;
using System.Collections.Generic;
using System.Text;

namespace AvaCarona.Domain
{
  public class Endereco
  {
    public int Logradouro { get; set; }
    public int Numero { get; set; }
    public int Complemento { get; set; }
    public int Bairro { get; set; }
    public int Cidade { get; set; }
    public int Estado { get; set; }
  }
}
