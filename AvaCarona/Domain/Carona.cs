using System;

namespace AvaCarona.Domain
{
  public class Carona
  {
    const int TOTAL_DE_VAGAS = 6;

    public Colaborador Ofertante { get; set; }
    public DateTime DataHoraSaida { get; set; }
    public Endereco EnderecoSaida { get; set; }
    public Endereco EnderecoDestino { get; set; }
    public int VagasDisponiveis { get; set; }
    public int TotalVagas { get; set; }


    public bool CriarCarona(DateTime dataHoraSaida)
    {
      if (dataHoraSaida != null)
      {
        VagasDisponiveis;
        return true;
      }

      return false;
    }
  }
}
