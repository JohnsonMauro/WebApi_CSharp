using AvaCarona.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AvaCarona.UnitTest
{
  [TestClass]
  public class ColaboradoresTest
  {
    [TestMethod]
    public void VerificarEid_SeMaiorQueTresEMenorQueVinte_IsTrue()
    {
      Colaborador colaborador = new Colaborador("Johnson Mauro", "j.da.silva.lima", 123456);

      var esperado = colaborador.ValidacaoEid(colaborador.Eid);

      Assert.IsTrue(esperado);
    }
  }
}
